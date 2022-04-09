using PogodaTVP.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PogodaTVP.UI.Controls
{
    public partial class WindControl : UserControl
    {
        public WindControl()
        {
            InitializeComponent();
        }
        public WindControl(AdobeWeatherWindDirection adobeWeatherWindDirection)
        {
            InitializeComponent();
            comboBox_WeatherDirectory.DisplayMember = "Key";
            comboBox_WeatherDirectory.ValueMember = "Value";
            comboBox_WeatherDirectory.DataSource = Enum.GetValues(typeof(AdobeWeatherWindDirection));
            comboBox_WeatherDirectory.SelectedItem = adobeWeatherWindDirection;
        }


        private void WindControl_Load(object sender, EventArgs e)
        {

        }
    }
}
