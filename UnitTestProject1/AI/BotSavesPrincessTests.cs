using hak.AI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.AI
{
    [TestClass]
    public class BotSavesPrincessTests
    {
        [TestMethod]
        public void BotSavesPrincessTest1()
        {
            var field = new string[]
            {
                "---",
                "-m-",
                "p--",
            };
            BotSavesPrincess.displayPathtoPrincess(3, field);
        }

        [TestMethod]
        public void BotSavesPrincessTest2()
        {
            var field = new string[]
            {
                "--p",
"-m-",
"---",
            };
            BotSavesPrincess.displayPathtoPrincess(3, field);
        }
    }
}