using Microsoft.Extensions.Configuration;
using PogodaTVP.Core.Enums;
using PogodaTVP.Logic.Interfaces;
using PogodaTVP.UI.Controls;
using PogodaTVP.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PogodaTVP.UI
{
    public partial class ClientPanel : Form
    {
        private readonly IConfiguration _configuration;
        private readonly IWeatherService _weatherService;
        private readonly IFileService _fileService;
       

        public ClientPanel(IConfiguration configuration, IWeatherService weatherService, IFileService fileService)
        {
            _weatherService = weatherService;
            _configuration = configuration;
            _fileService = fileService;
            InitializeComponent();
        }



        private async void button1_Click_PobierzPogode(object sender, EventArgs e)
        {
            var listDays = new List<WeatherDay>();
            var listParts = new List<WeatherPart>();
            var checkedListBoxDays = checkedListBox_Days.CheckedItems;
            var checkedListBoxWeatherParts = checkedListBox_WeatherParts.CheckedItems;

            foreach (string item in checkedListBoxDays)
            {
                var enumName = item.Replace(" ", "");
                Console.WriteLine(enumName);
                listDays.Add(Enum.Parse<WeatherDay>(enumName, true));
            }

            foreach (string item in checkedListBoxWeatherParts)
            {
                var enumName = item.Replace(" ", "");
                Console.WriteLine(enumName);
                listParts.Add(Enum.Parse<WeatherPart>(enumName, true));
            }


            var controls = CreateWeatherUserControl(listDays, listParts);

            foreach (var control in controls)
            {
                control.control.CreateControl();

                switch (control.weatherPart)
                {
                    case WeatherPart.Noc:
                        addControlToFlowLayoutPanel(flowLayoutPanel_OpolszczyznaNoc, control.control);
                        break;
                    case WeatherPart.PrzedPoludniem:
                        addControlToFlowLayoutPanel(flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem, control.control);
                        break;
                    case WeatherPart.PoPoludniu:
                        addControlToFlowLayoutPanel(flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu, control.control);
                        break;
                    default:
                        break;
                }


            }


        }


        private void addControlToFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel, Control control)
        {
            flowLayoutPanel.Controls.Add(control);
        }
        public IEnumerable<WeatherControlModel> CreateWeatherUserControl(List<WeatherDay> weatherDays, List<WeatherPart> weatherParts)
        {
            var meteomaxFile = _weatherService.GetWeatherFileFromMeteoService();
            var meteomax = _weatherService.GetWeatherFromXml(meteomaxFile);

            foreach (var weatherDay in weatherDays)
            {

                foreach (var weatherPart in weatherParts)
                {
                    var weather = _weatherService.GetWeatherRegion(meteomax, weatherDay, weatherPart);
                    foreach (var miasto in weather.PogodaMiasto)
                    {
                        var box = new CityWeather();
                        box.label1_City.Text = miasto.Miasto;
                        box.dateTimePicker1_Data.Value = Convert.ToDateTime(weather.Dzień);
                        box.textBox3_Pressure.Text = weather.hPa;
                        box.textBox2_temp.Text = miasto.Temperatura;
                        box.comboBox1_SytuacjaPogodowa.DisplayMember = "Key";
                        box.comboBox1_SytuacjaPogodowa.ValueMember = "Value";
                        box.comboBox1_SytuacjaPogodowa.DataSource = Enum.GetValues(typeof(AdobeWeatherSituation));
                        box.comboBox1_SytuacjaPogodowa.SelectedItem = miasto.SytuacjaPogodowa;
                        yield return new WeatherControlModel(box, weatherDay, weatherPart);
                    }
                }
            }
        }

        public async void button_GenerateAdobe_Click(object sender, EventArgs e)
        {
              
            FileInfo pathToOpolszczyznaNocTemplate = new FileInfo(@"..\..\..\..\PogodaTVP\Data\PogodaRejdych\OPOLSZCZYZNA_NOC\definition.json");
            FileInfo pathToOpolszczyznaDzienTemplate = new FileInfo(@"..\..\..\..\PogodaTVP\Data\PogodaRejdych\OPOLSZCZYZNA_DZIEN\definition.json");     

            DirectoryInfo pathToGenerateData = new DirectoryInfo(@"..\..\..\..\PogodaTVP\Data\GeneratedAdobeWeather\");
            var pathToExport = new DirectoryInfo(@_configuration.GetSection("Premiere").GetSection("PathForMogrtFiles").Value);

            if (flowLayoutPanel_OpolszczyznaNoc.Controls.Count > 0)
            {
                var jsonData = File.ReadAllText(pathToOpolszczyznaNocTemplate.FullName);
                var outDirectory = CreateNewDirectoryByState(pathToGenerateData, WeatherPart.Noc.ToString(), pathToOpolszczyznaNocTemplate);
                var adobeFile = GenerateAdobeFile(outDirectory, jsonData, flowLayoutPanel_OpolszczyznaNoc.Controls, WeatherPart.Noc, pathToOpolszczyznaNocTemplate);
                MoveFile(adobeFile, pathToExport);
            }

            if (flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem.Controls.Count > 0)
            {
                var jsonData = File.ReadAllText(pathToOpolszczyznaDzienTemplate.FullName);
                var outDirectory = CreateNewDirectoryByState(pathToGenerateData, WeatherPart.PrzedPoludniem.ToString(), pathToOpolszczyznaDzienTemplate);
                var adobeFile = GenerateAdobeFile(outDirectory, jsonData, flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem.Controls, WeatherPart.PrzedPoludniem, pathToOpolszczyznaDzienTemplate) ;
                MoveFile(adobeFile, pathToExport);
            }

            if (flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu.Controls.Count > 0)
            {
                var jsonData = File.ReadAllText(pathToOpolszczyznaDzienTemplate.FullName);
                var outDirectory = CreateNewDirectoryByState(pathToGenerateData, WeatherPart.PoPoludniu.ToString(), pathToOpolszczyznaDzienTemplate);
                var adobeFile = GenerateAdobeFile(outDirectory, jsonData, flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu.Controls, WeatherPart.PoPoludniu, pathToOpolszczyznaDzienTemplate);
                MoveFile(adobeFile, pathToExport);
            }

           
        }

        private FileInfo CreateNewDirectoryByState(DirectoryInfo oldDirectory, string state, FileInfo fileName )
        {
            return new FileInfo($@"{oldDirectory.FullName}\{state}\{fileName.Name}");
        }

        private bool MoveFile(FileInfo fileToMove,DirectoryInfo pathToMove)
        {
            try
            {
                fileToMove.MoveTo(pathToMove.FullName, true);
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Nie udalo się przenieść pliku do: " + pathToMove.FullName);
                return false;
            }
           
        }

        private bool SaveToTargetFolder(string json,FileInfo targetFile)
        {
            if (!targetFile.Directory.Exists)
            {
                Directory.CreateDirectory(targetFile.Directory.FullName);
            }
            
                File.Create(targetFile.FullName).Close();
                
            

            File.WriteAllText(targetFile.FullName, json);
            if (targetFile.Exists)
            {
                return true;
            }
            throw new Exception("Failed when saved filed to Target folder");
        }


        private FileInfo GenerateAdobeFile(FileInfo fileJson, string jsonData, Control.ControlCollection controls,WeatherPart weatherPart, FileInfo templateFilePath)
        {
            List<FileInfo> requiredFiles = new List<FileInfo>()
            {
                new FileInfo(@$"..\..\..\..\PogodaTVP\Data\PogodaRejdych\{templateFilePath.Directory.Name}\project.aegraphic"),
                new FileInfo(@$"..\..\..\..\PogodaTVP\Data\PogodaRejdych\{templateFilePath.Directory.Name}\thumb.png")

            };


            // mapowanie
            var json = MapCitiesToAdobe(jsonData, controls, weatherPart);
            // zapisanie do folderu wysjciowego
            SaveToTargetFolder(json, fileJson);
            // add Required files
            foreach (var file in requiredFiles)
            {
                file.CopyTo(@$"{fileJson.Directory.FullName}\{file.Name}",true);
            }
            // zip folderu wyjsciowego
            var zippedFile = _fileService.ZippFile(fileJson); 
            return _fileService.ChangeFileExtensionToMogrt(zippedFile); // adobe czyta .mogrt            


        }

        public string ReplaceGuidToProjectPressureInAdobeJsonFile(string jsonString, decimal pressure)
        {
            return jsonString.Replace("cd57a8cf-cc2b-42e3-b344-fb5bb30d0485", $"{pressure.ToString()} hPa");

        }
    
       public string ReplaceGuidToProjectWeatherNameInAdobeJsonFile(string jsonString, WeatherPart weatherPart )
        {                          
          return jsonString.Replace("eea862b9-04a2-4428-8419-270ae6b27dbe", weatherPart.ToString());                   
        }
     
        public string ReplaceGuidsToTemperatureInAdobeJsonFile(string jsonString, string miasto, int temp)
        {

            switch (miasto) // all guids are implemented in template
            {
                case "NAMYSLOW":
                    return jsonString.Replace("b1d6477b-594e-4948-929d-7440a1b2f3b8", temp.ToString());

                case "KLUCZBORK":
                    return jsonString.Replace("73c9dcda-d8af-439c-b23d-a2d8188fbf28", temp.ToString());

                case "OLESNO":
                    return jsonString.Replace("b5ea6d6f-1435-4de7-95a3-0d150d0ee518", temp.ToString());
                    
                case "BRZEG":
                    return jsonString.Replace("16300f80-af26-48aa-87df-5d022360c2fc", temp.ToString());
                   
                case "OPOLE":
                    return jsonString.Replace("82eddb7c-47fa-4379-9b18-ed50e2a8112f", temp.ToString());
                   
                case "STRZELCE":
                    return jsonString.Replace("7de5b7e5-f87d-40e2-bdc3-79962c4f4c0b", temp.ToString());
                    
                case "NYSA":
                    return jsonString.Replace("fc478039-f0cf-4ff2-977c-df63f55f2f8d", temp.ToString());
                    
                case "KRAPKOWICE":
                    return jsonString.Replace("2733d7aa-f5eb-4aaf-9304-32445346714d", temp.ToString());
                   
                case "KEDZIERZYN":
                    return jsonString.Replace("0977a584-7974-48ef-842b-8d1cdb5b3a79", temp.ToString());
                   
                case "PRUDNIK":
                    return jsonString.Replace("f6ab2e23-5c4d-475b-94c0-f555dcd601f4", temp.ToString());
                   
                case "GLUBCZYCE":
                    return jsonString.Replace("b44f58ef-f741-4e15-8c63-377255196f84", temp.ToString());
                   
                default:
                    return jsonString;
            }



        }

        public string ReplaceGuidsToWeatherInAdobeJsonFile(string jsonString, string miasto, AdobeWeatherSituation adobeWeatherSituation)
        {

            switch (miasto) // all guids are implemented in template
            {
                case "NAMYSLOW":
                    return jsonString.Replace("9eeca3d1-5468-4469-923e-d4f2a30660b2", ((int)adobeWeatherSituation).ToString());

                case "KLUCZBORK":
                    return jsonString.Replace("b9a8d3d6-aedc-4c30-96e5-9024066fdd20", ((int)adobeWeatherSituation).ToString());

                case "OLESNO":
                    return jsonString.Replace("144808d5-7d4b-44a1-a33a-4145da1caea8", ((int)adobeWeatherSituation).ToString());

                case "BRZEG":                                                   
                    return jsonString.Replace("1c0c8a24-d0ff-42c7-804a-4928d60aca2c", ((int)adobeWeatherSituation).ToString());

                case "OPOLE":                                                        
                    return jsonString.Replace("a9b91b54-100c-4da5-8b10-3360f99bfa37", ((int)adobeWeatherSituation).ToString());

                case "STRZELCE":                                                  
                    return jsonString.Replace("cb6bb0b7-08c0-44ea-9b0d-c06438bdbec2", ((int)adobeWeatherSituation).ToString());

                case "NYSA":                                                         
                    return jsonString.Replace("f71dea99-a0c7-47a3-8106-c57ba2b4fb4d", ((int)adobeWeatherSituation).ToString());

                case "KRAPKOWICE":                                                
                    return jsonString.Replace("c74d56ac-dab8-4e63-a51f-cb59a39c04a7", ((int)adobeWeatherSituation).ToString());

                case "KEDZIERZYN":                                                   
                    return jsonString.Replace("4679cf30-402c-4f9c-9de2-0989f9dc7cee", ((int)adobeWeatherSituation).ToString());

                case "PRUDNIK":                                                   
                    return jsonString.Replace("d38c03e4-3eb4-4eee-b7d6-b0626412cd65", ((int)adobeWeatherSituation).ToString());

                case "GLUBCZYCE":                                                  
                    return jsonString.Replace("cd44ca71-a6bb-4a98-af06-1ce2989260af", ((int)adobeWeatherSituation).ToString());

                default:
                    return jsonString;
            }



        }


        private string MapCitiesToAdobe(string jsonData, Control.ControlCollection controls,WeatherPart weatherPart)
        {

            jsonData = ReplaceGuidToProjectWeatherNameInAdobeJsonFile(jsonData, weatherPart);
            if (controls.Count > 0)
            {
                jsonData = ReplaceGuidToProjectPressureInAdobeJsonFile(jsonData, Convert.ToDecimal(((CityWeather)controls[0]).textBox3_Pressure.Text));
            }



            foreach (CityWeather control in controls)
            {
                var miasto = control.label1_City.Text.ToUpper();

                if (miasto.Equals("KĘDZIERZYN-KOŹLE"))
                {
                    miasto = miasto.Replace("KĘDZIERZYN-KOŹLE", "KEDZIERZYN");
                }

                if (miasto.Equals("NAMYSŁÓW"))
                {
                    miasto = miasto.Replace("NAMYSŁÓW", "NAMYSLOW");
                }

                if (miasto.Equals("STRZELCE OPOLSKIE"))
                {
                    miasto = miasto.Replace("STRZELCE OPOLSKIE", "STRZELCE");
                }

                if (miasto.Equals("GŁUBCZYCE"))
                {
                    miasto = miasto.Replace("GŁUBCZYCE", "GLUBCZYCE");
                }             
                jsonData = ReplaceGuidsToTemperatureInAdobeJsonFile(jsonData, miasto, Convert.ToInt16(control.textBox2_temp.Text));
                jsonData = ReplaceGuidsToWeatherInAdobeJsonFile(jsonData,miasto, Enum.Parse<AdobeWeatherSituation>(control.comboBox1_SytuacjaPogodowa.Text));
            }
            return jsonData;
        }
    }
}
