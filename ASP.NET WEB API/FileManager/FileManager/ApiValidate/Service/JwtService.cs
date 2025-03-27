using FileManager.Context;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace FileManager.ApiValidate.Service
{
    public class JwtService
    {
        private readonly IConfiguration _configuration;
        public FileApiContext _fileApiContext { get; }

        public JwtService(FileApiContext fileApiContext, IConfiguration configuration)
        {
            _fileApiContext = fileApiContext;
            _configuration = configuration;
        }

        public  async Task<ApiAuthenticationResponse>? AuthenticateApi(ApiAuthentication apiAuthentication)
        {
            if(string.IsNullOrWhiteSpace(apiAuthentication.UserName) || string.IsNullOrWhiteSpace(apiAuthentication.Password))
            {
                return null;
            }
            //Dummy password validation
            if(apiAuthentication.Password != "abc123")
                return null;

            var issuer = _configuration["JwtConfig:Issuer"];
            var audience = _configuration["JwtConfig:Audience"];
            var key = _configuration["JwtConfig:Key"];
            var tokenValidityMins = _configuration.GetValue<int>("JwtConfig:TokenValidityMins");

            var tokenExpiryTimeStamp = DateTime.UtcNow.AddMinutes(tokenValidityMins);

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.Name,apiAuthentication.UserName)
                }),
                Expires = tokenExpiryTimeStamp,
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes(key)),
                    SecurityAlgorithms.HmacSha512Signature),
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            var accessToken = tokenHandler.WriteToken(securityToken);


            return new ApiAuthenticationResponse()
            {
                UserName = apiAuthentication.UserName,
                AccessToken = accessToken,
                ExpiresIn = (int)tokenExpiryTimeStamp.Subtract(DateTime.UtcNow).TotalSeconds
            };
        }
    }
}
