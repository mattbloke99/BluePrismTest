using BluePrismTechnicalTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class WordLaddersTests
    {
        [Test]
        public void FindLaddersTest()
        {
            IList<string> testWordDictionary = new List<string> { "hit","hot", "dot", "dog", "lot", "log", "cog" };
            
            IEnumerable<IList<string>> ladders = new WordLadders().FindLadders("hit", "cog", testWordDictionary);

            IList<string> expectedLadder = new List<string> { "hit", "hot", "dot", "dog", "cog" };

            foreach (var ladder in ladders)
            {
                if(ladder.SequenceEqual(expectedLadder))
                {
                    Assert.Pass();
                    break;
                }
            }
        }

        [Test]
        public void FindLaddersCaseSensitiveTest()
        {
            IList<string> testWordDictionary = new List<string> { "hit", "hot", "dot", "dog", "lot", "log", "cog" };

            IEnumerable<IList<string>> ladders = new WordLadders().FindLadders("Hit", "Cog", testWordDictionary);

            IList<string> expectedLadder = new List<string> { "hit", "hot", "dot", "dog", "cog" };

            foreach (var ladder in ladders)
            {
                if (ladder.SequenceEqual(expectedLadder))
                {
                    Assert.Pass();
                    break;
                }
            }
        }
    }
}