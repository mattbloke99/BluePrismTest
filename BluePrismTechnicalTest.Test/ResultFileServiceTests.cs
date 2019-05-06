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

            var resultsFile = new List<string> { "Spin", "Spit", "Spot"};

            ResultFileService resultFileService = new ResultFileService(@"C:\Users\Matt\source\repos\BluePrismTechnicalTest\BluePrismTechnicalTest\results-file.txt");

            resultFileService.Write(resultsFile);
            resultFileService = null;

            DictionaryLoader dictionaryLoader = new DictionaryLoader(@"C:\Users\Matt\source\repos\BluePrismTechnicalTest\BluePrismTechnicalTest\results-file.txt");

            Assert.IsInstanceOf<IEnumerable<string>>(dictionaryLoader.LadderDictionary);
            Assert.NotZero(dictionaryLoader.LadderDictionary.Count());

        }
    }
}