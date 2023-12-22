using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANSIConverter.Service
{
    public class EncodingService : IEncodingService
    {
        public string ChangeEncodeToANSI(string path, ProgressBar progressBar)
        {

            var line = "";
            string fileNameWithoutExtension = path.Split(".csv")[0];
            string finalPath = $"{fileNameWithoutExtension}_ANSI.csv";
            var streamWritter = new StreamWriter(finalPath, false, Encoding.Latin1);

            using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), Encoding.Latin1))
            {
                Stream baseStream = reader.BaseStream; long length = baseStream.Length;

                var header = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (header)
                    {
                        streamWritter.WriteLine(line);
                        header = false;
                        continue;
                    }

                    streamWritter.WriteLine(line);

                    progressBar.Value = Convert.ToInt32((double)baseStream.Position / length * 100);

                    Application.DoEvents();
                }

                return finalPath;
            }
        }
    }
}
