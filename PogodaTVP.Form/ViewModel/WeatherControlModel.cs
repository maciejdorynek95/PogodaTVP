using PogodaTVP.Core.Enums;
using System.Windows.Forms;

namespace PogodaTVP.UI.ViewModel
{
    public class WeatherControlModel
    {
        public Control control { get; set; }
        public WeatherDay weatherDay { get; set; }
        public WeatherPart weatherPart { get; set; }

        public WeatherControlModel(Control control, WeatherDay weatherDay, WeatherPart weatherPart)
        {
            this.control = control;
            this.weatherDay = weatherDay;
            this.weatherPart = weatherPart;
        }

    }

   
}
