using Microsoft.Extensions.Configuration;
using PogodaTVP.Core.Models.Cumulus;
using PogodaTVP.Logic.Interfaces;

namespace PogodaTVP.Logic.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly IConfiguration _configuration;
        public AuthorizationService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Authorization CreateAuthorizationToken()
        {
            return new Authorization(_configuration.GetSection("ApiKey1").Value, _configuration.GetSection("ApiKey2").Value);
        }
        public Authorization CreateAuthorizationToken(string ApiKey1, string ApiKey2)
        {
            return new Authorization(ApiKey1, ApiKey2);
        }

    }
}
