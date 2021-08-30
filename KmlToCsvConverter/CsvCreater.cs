using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmlToCsvConverter
{
    class CsvCreater
    {
        public static bool CreatCsvForCoordinates(string coordinates, string csvPath)
        {
            try
            {
                List<string> cor = coordinates.Replace(',', ';').Replace('.', ',').Split(' ').ToList();

                using (StreamWriter writer = new(new FileStream(csvPath, FileMode.Create, FileAccess.Write)))
                {
                    foreach (var coordinate in cor)
                    {
                        writer.WriteLine(coordinate);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
