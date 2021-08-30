using System;
using System.IO;
using System.Xml;

namespace KmlToCsvConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string coordinates = XmlReader.ReadCoordinatesFromXml(args[0]);

            CsvCreater.CreatCsvForCoordinates(coordinates, args[1]);
            JsonCreater.CreatJsonFileForCoordinates(coordinates, args[2]);
        }
    }
}
