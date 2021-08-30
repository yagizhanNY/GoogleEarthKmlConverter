using System.IO;
using System.Xml;

namespace KmlToCsvConverter
{
    class XmlReader
    {
        public static string ReadCoordinatesFromXml(string xmlPath)
        {
            FileStream fs = new(xmlPath,
                FileMode.Open, FileAccess.Read);

            XmlDocument xmlDoc = new();
            xmlDoc.Load(fs);

            XmlNamespaceManager manager = new(xmlDoc.NameTable);
            manager.AddNamespace("sp", "http://www.opengis.net/kml/2.2");

            XmlNode coordinateNode = xmlDoc.DocumentElement.SelectSingleNode("//sp:coordinates", manager);
            return coordinateNode.InnerText.Trim();
        }
    }
}
