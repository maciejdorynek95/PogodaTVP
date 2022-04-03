using Newtonsoft.Json;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace PogodaTVP.Logic.Helpers
{
    public static class XmlHelper
    {

        public static T XmlDeserializer <T>(string xmlFilePath)
        {
            // Create an instance of the XmlSerializer specifying type.
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            // Create a TextReader to read the file.
            using (FileStream fs = new FileStream(xmlFilePath, FileMode.OpenOrCreate))
            {
                TextReader reader = new StreamReader(fs);
                return (T)serializer.Deserialize(reader);
            };
        }

        public static string XmlToJsonSerializer(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string jsonText = JsonConvert.SerializeXmlNode(doc);

            return jsonText;
        }
    }
}
