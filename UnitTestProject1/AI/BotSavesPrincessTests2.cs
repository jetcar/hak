using hak.AI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.AI
{
    [TestClass]
    public class BotSavesPrincessTests2
    {
        [TestMethod]
        public void BotSavesPrincessTest1()
        {
            var field = new string[]
            {
                "-----",
"-----",
"p----",
"-----",
"-----"
            };
            BotSavesPrincess2.nextMove(5, 2, 3, field);
        }

        [TestMethod]
        public void BotSavesPrincessTest2()
        {
            var field = new string[]
            {
                "-p---",
"-----",
"-----",
"--m--",
"-----",
            };
            BotSavesPrincess2.nextMove(5, 3, 2, field);
        }
    }
}