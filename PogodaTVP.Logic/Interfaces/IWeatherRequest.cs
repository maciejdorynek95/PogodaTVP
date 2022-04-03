using System.Net;

namespace PogodaTVP.Logic.Interfaces
{
    public interface IWeatherRequest
    {
        HttpWebRequest CreateRequestPOST(string queryString);
        HttpWebResponse SendRequest(HttpWebRequest request, string queryString);
    }
}
