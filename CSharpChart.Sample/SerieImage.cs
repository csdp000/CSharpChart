using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CSharpChart.Sample
{

    [Serializable]
    public class SerieImage
    {
        public Image Image { get; set; }
        public string SerieName { get; set; }
        public string Description { get; set; }
        public static List<SerieImage> LoadSerieImages(string fileName)
        {
            var formatter = new BinaryFormatter();
            List<SerieImage> option;
            try
            {
                using (var readerFileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    option = formatter.Deserialize(readerFileStream) as List<SerieImage>;

                    readerFileStream.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return option;
        }
        public static void SaveSerieImages(List<SerieImage> serieImages, string fileName)
        {
            var formatter = new BinaryFormatter();
            try
            {
                using (var writerFileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(writerFileStream, serieImages);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
