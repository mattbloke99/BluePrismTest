using BluePrismTechnicalTest;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void GetWordsOfLengthTest()
        {
            IList<string> testWordDictionary = new List<string> { "spin", "spit", "spat", "spot", "span", "spelling","spelt","sparkling" };

            IEnumerable<string> wordLadderDictionary = new WordLadderDictionary(testWordDictionary).GetWordsOfLength(4); ;

            Assert.IsTrue(testWordDictionary.Count() > wordLadderDictionary.Count());
        }
    }
}