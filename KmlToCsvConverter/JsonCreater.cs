using KmlToCsvConverter.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KmlToCsvConverter
{
    class JsonCreater
    {
        public static bool CreatJsonFileForCoordinates(string coordinates, string jsonPath)
        {
            try
            {
                List<string> cor = coordinates.Replace(',', ';').Replace('.', ',').Split(' ').ToList();

                List<Coordinates> coordinatesList = new();

                foreach (var coordinate in cor)
                {
                    string[] corArray = coordinate.Split(';');

                    coordinatesList.Add(new Coordinates()
                    {
                        Longitude = (float)Convert.ToDouble(corArray[0]),
                        Latitude = (float)Convert.ToDouble(corArray[1])
                    });
                }

                string jsonText = JsonSerializer.Serialize(coordinatesList);
                File.WriteAllText(jsonPath, jsonText);

                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
