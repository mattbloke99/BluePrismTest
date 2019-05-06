using System.Collections.Generic;
using System.Linq;

namespace BluePrismTechnicalTest
{
    public class WordLadderDictionary
    {
        private readonly IEnumerable<string> testWordDictionary;

        public WordLadderDictionary(IEnumerable<string> testWordDictionary) => this.testWordDictionary = testWordDictionary;

        public IEnumerable<string> GetWordsOfLength(int wordLength) => testWordDictionary.Where(o => o.Length == 4);
    }
}