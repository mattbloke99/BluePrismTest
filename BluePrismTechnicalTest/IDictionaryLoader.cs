using System.Collections.Generic;

namespace BluePrismTechnicalTest
{
    public interface IDictionaryLoader
    {
        IEnumerable<string> Load(string filePath);
    }
}