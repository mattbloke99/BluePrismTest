using BluePrismTechnicalTest;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class DictionaryLoaderTest
    {
        [Test]
        public void DictionaryLoaderReturnWordsTest() {

            Mock<IDictionaryLoader> sut = new Mock<IDictionaryLoader>();
            sut.Setup(x => x.Load(It.IsAny<string>())).Returns(new List<string>() { "word1", "word2" });
            IDictionaryLoader dictionaryLoader = sut.Object;

            IEnumerable<string> results = dictionaryLoader.Load(string.Empty);

            Assert.IsInstanceOf<IEnumerable<string>>(results);
            Assert.NotZero(results.Count());
        }
    }
}