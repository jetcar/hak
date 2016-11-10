using hak.AI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.AI
{
    [TestClass()]
    public class BotCleanTests
    {
        [TestMethod()]
        public void next_moveTest()
        {
            var board = new string[]
            {
                "b---d",
                "-d--d",
                "--dd-",
                "--d--",
                "----d",
            };
            Assert.AreEqual("RIGHT", BotClean.next_move(0, 0, board));
        }

        [TestMethod()]
        public void next_moveTest2()
        {
            var board = new string[]
            {
                "-b--d",
                "-d--d",
                "--dd-",
                "--d--",
                "----d",
            };
            Assert.AreEqual("RIGHT", BotClean.next_move(0, 1, board));
        }

        [TestMethod()]
        public void next_moveTest3()
        {
            var board = new string[]
            {
                "----d",
                "-d---",//-b---
                "--dd-",
                "--d--",
                "----d",
            };
            Assert.AreEqual("DOWN", BotClean.next_move(1, 0, board));
        }

        [TestMethod()]
        public void next_moveTest31()
        {
            var board = new string[]
            {
                "-b--d",
                "-----",
                "--dd-",
                "--d--",
                "----d",
            };
            Assert.AreEqual("DOWN", BotClean.next_move(1, 1, board));
        }

        [TestMethod()]
        public void next_moveTest312()
        {
            var board = new string[]
            {
                "-b--d",
                "-d---",
                "--dd-",
                "--d--",
                "----d",
            };
            Assert.AreEqual("RIGHT", BotClean.next_move(2, 1, board));
        }

        [TestMethod()]
        public void next_moveTest4()
        {
            var board = new string[]
            {
                "-----",
                "-----",//-b---
                "d--d-",
                "---d-",
                "--d-d",
            };
            Assert.AreEqual("LEFT", BotClean.next_move(1, 1, board));
        }

        [TestMethod()]
        public void next_moveTest42()
        {
            var board = new string[]
            {
                "-----",
                "-----",
                "---d-",
                "---d-",
                "--d-d",
            };

            Assert.AreEqual("DOWN", BotClean.next_move(1, 1, board));
        }

        [TestMethod()]
        public void next_moveTest43()
        {
            var board = new string[]
            {
                "-----",
                "-----",
                "d--d-",
                "---d-",
                "--d-d",
            };
            Assert.AreEqual("LEFT", BotClean.next_move(1, 1, board));
        }

        [TestMethod()]
        public void next_moveTest44()
        {
            var board = new string[]
            {
                "-----",
                "-----",
                "d--d-",
                "---d-",
                "--d-d",
            };
            Assert.AreEqual("DOWN", BotClean.next_move(1, 0, board));
        }

        [TestMethod()]
        public void next_moveTest41()
        {
            var board = new string[]
            {
                "-d---",
                "-d---",
                "d--d-",
                "---d-",
                "--d-d",
            };
            Assert.AreEqual("RIGHT", BotClean.next_move(2, 1, board));
        }

        [TestMethod()]
        public void next_moveTest5()
        {
            var board = new string[]
            {
                "-d---",
                "-d---",
                "---d-",
                "---d-",
                "--d-d",
            };
            Assert.AreEqual("DOWN", BotClean.next_move(2, 3, board));
        }

        [TestMethod()]
        public void next_moveTest6()
        {
            var board = new string[]
            {
                "-----",
                "-----",
                "-----",
                "-----",
                "--d-d",
            };
            Assert.AreEqual("LEFT", BotClean.next_move(3, 3, board));
        }

        [TestMethod()]
        public void next_moveTest61()
        {
            var board = new string[]
            {
                "-----",
                "-----",
                "-----",
                "---d-",
                "--d-d",
            };
            Assert.AreEqual("DOWN", BotClean.next_move(3, 2, board));
        }

        [TestMethod()]
        public void next_moveTest7()
        {
            var board = new string[]
            {
                "-d---",
                "-d---",
                "---d-",
                "---d-",
                "--d-d",//--b--
            };
            Assert.AreEqual("RIGHT", BotClean.next_move(4, 3, board));
        }
    }
}