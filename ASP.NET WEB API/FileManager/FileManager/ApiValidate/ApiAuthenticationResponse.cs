﻿namespace FileManager.ApiValidate
{
    public class ApiAuthenticationResponse
    {
        public string UserName { get; set; }
        public string AccessToken { get; set; }
        public int ExpiresIn { get; set; }
    }
}
