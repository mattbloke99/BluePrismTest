using System.Collections.Generic;
using System.IO;

namespace BluePrismTechnicalTest
{
    public class ResultFileService
    {
        private string filePath;

        public ResultFileService(string filePath) => this.filePath = filePath;

        public void Write(IEnumerable<string> resultsFile)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            else
            {
                File.Delete(filePath);
            }

            using (var tw = new StreamWriter(filePath, true))
            {
                foreach (var word in resultsFile)
                {
                    tw.WriteLine(word);
                }
            }
        }
    }
}