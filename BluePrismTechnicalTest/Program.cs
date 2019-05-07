using System.Collections.Generic;
using System.Linq;

namespace BluePrismTechnicalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO add some validation around these command arguments
            string dictionaryFile = args[0];
            string startWord = args[1];
            string endWord = args[2];
            string resultFile = args[3];

            IEnumerable<string> ladderDictionary = new DictionaryLoader().Load(dictionaryFile);

            ladderDictionary = new WordLadderDictionary(ladderDictionary).GetWordsOfLength(4); ;

            IEnumerable<IList<string>> ladders = new WordLadders().FindLadders(startWord, endWord, ladderDictionary.ToList());

            ResultFileService resultFileService = new ResultFileService(resultFile);

            resultFileService.Write(ladders.First());
        }
    }
}
