using PogodaTVP.Core.Models.Cumulus;

namespace PogodaTVP.Logic.Interfaces
{
    public interface IAuthorizationService
    {
        Authorization CreateAuthorizationToken();
        Authorization CreateAuthorizationToken(string ApiKey1, string ApiKey2);
    }
}
