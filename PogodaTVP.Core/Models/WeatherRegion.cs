using System.Collections.Generic;

namespace PogodaTVP.Core.Models
{
    public class WeatherRegion
    {
        public string Wersja { get; set; } // dzień / noc
        public string Dzień { get; set; } // dziś / jutro
        public string hPa { get; set; }
        public List<WeatherCity> PogodaMiasto { get; set; }
    }
}
