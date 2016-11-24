using hak.Leet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.Leet.Tests
{
    [TestClass()]
    public class WordsWar2Tests
    {
        [TestMethod()]
        public void WordBreakTest()
        {
            var list = WordsWar2.WordBreak("catsanddog", new HashSet<string>() { "cat", "cats", "and", "sand", "dog" });
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("cats and dog", list[0]);
            Assert.AreEqual("cat sand dog", list[1]);
        }
    }
}