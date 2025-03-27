using FileManager.ApiValidate;
using FileManager.ApiValidate.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FileManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateApiController : ControllerBase
    {
        private readonly JwtService _jwtService;

        public AuthenticateApiController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<ApiAuthenticationResponse>> Authenticate(ApiAuthentication apiAuthentication)
        {
            var result = await _jwtService.AuthenticateApi(apiAuthentication);

            if(result == null)
            {
                return Unauthorized();
            }
            return result;
        }
    }
}
