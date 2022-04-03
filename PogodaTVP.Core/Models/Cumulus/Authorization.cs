namespace PogodaTVP.Core.Models.Cumulus
{
    public class Authorization
    {
        public string ApiKey1 { get; private set; }
        public string ApiKey2 { get; private set; }

        public Authorization(string apiKey1, string apiKey2)
        {
            ApiKey1 = apiKey1;
            ApiKey2 = apiKey2;
        }

    }


}
