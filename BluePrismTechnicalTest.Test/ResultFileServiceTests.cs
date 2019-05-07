using BluePrismTechnicalTest;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class ResultFileServiceTests
    {
        [Test]
        public void SaveResultFileServiceTest()
        {
            IList<string> resultsFile = new List<string> { "Spin", "Spit", "Spot"};

            ResultFileService resultFileService = new ResultFileService(@"results-file.txt");

            resultFileService.Write(resultsFile);
            resultFileService = null;

            IDictionaryLoader dictionaryLoader = new DictionaryLoader();

            IEnumerable<string> dictionary = dictionaryLoader.Load(@"results-file.txt");

            Assert.IsInstanceOf<IEnumerable<string>>(dictionary);
            Assert.NotZero(dictionary.Count());
        }
    }
}