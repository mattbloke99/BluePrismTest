using System.Collections.Generic;
using System.IO;

namespace BluePrismTechnicalTest
{
    public class DictionaryLoader : IDictionaryLoader
    {
        public IEnumerable<string> Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Could not load {filePath}");
            }

            IList<string> ladderDictionary = new List<string>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    ladderDictionary.Add(line);

                }

                return ladderDictionary;
            }
        }
    }
}