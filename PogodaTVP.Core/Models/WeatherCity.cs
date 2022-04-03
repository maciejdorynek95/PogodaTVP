using PogodaTVP.Core.Enums;

namespace PogodaTVP.Core.Models
{
    public class WeatherCity
    {
      
        public string Miasto { get; set; }
       
        private string temperatura;
        public string Temperatura 
        {
            get { return temperatura.ToString(); }
            set { temperatura = value; } 
        }

        public AdobeWeatherSituation SytuacjaPogodowa 
        {
            get;

            set; 
        }

      
    }
}