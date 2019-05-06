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
            var testWordDictionary = new List<string> { "hit","hot", "dot", "dog", "lot", "log", "cog" };
            
            var ladders = new WordLadders().FindLadders("hit", "cog", testWordDictionary);

            var expectedLadder = new List<string> { "hit", "hot", "dot", "dog", "cog" };

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
            var testWordDictionary = new List<string> { "hit", "hot", "dot", "dog", "lot", "log", "cog" };

            var ladders = new WordLadders().FindLadders("Hit", "Cog", testWordDictionary);

            var expectedLadder = new List<string> { "hit", "hot", "dot", "dog", "cog" };

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