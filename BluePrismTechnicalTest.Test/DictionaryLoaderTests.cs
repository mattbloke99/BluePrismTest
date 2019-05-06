using BluePrismTechnicalTest;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class DictionaryLoaderTest
    {
        [Test]
        public void DictionaryLoaderReturnWordsTest()
        {

            DictionaryLoader dictionaryLoader = new DictionaryLoader(@"C:\Users\Matt\source\repos\BluePrismTechnicalTest\BluePrismTechnicalTest\words-english.txt");

            Assert.IsInstanceOf<IEnumerable<string>>(dictionaryLoader.LadderDictionary);
            Assert.NotZero(dictionaryLoader.LadderDictionary.Count());
        }
    }

    //public class WordPathService
    //{
    //    private IEnumerable<string> _orderdFourLetterWordDictionary;

    //    public WordPathService(IEnumerable<string> testWordDictionary)
    //    {

    //        _orderdFourLetterWordDictionary = GetOrderedFourLetterWordDictionary(testWordDictionary);
    //    }

    //    private IEnumerable<string> GetOrderedFourLetterWordDictionary(IEnumerable<string> testWordDictionary) => testWordDictionary.Where(o => o.Length == 4).OrderBy(o => o);

    //    public IEnumerable<string> GetWordPath(string startWord, string endWord)
    //    {
    //        var startWordIndex = GetWordIndex(startWord);
    //        var endWordIndex = GetWordIndex(endWord);

    //        return _orderdFourLetterWordDictionary.Skip(startWordIndex).Take((endWordIndex - startWordIndex)+1);
    //    }

    //    private int GetWordIndex(string word)
    //    {
    //        //TODO add some error checking around this
    //        var wordResult = _orderdFourLetterWordDictionary
    //    .Select((x, i) => new { Item = x, Index = i })
    //    .Where(itemWithIndex => itemWithIndex.Item.Equals(word, StringComparison.InvariantCultureIgnoreCase))
    //    .FirstOrDefault();

    //        return wordResult.Index;
    //    }
    //}
}