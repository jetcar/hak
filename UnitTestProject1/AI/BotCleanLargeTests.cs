using hak.AI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.AI.Tests
{
    [TestClass()]
    public class BotCleanLargeTests
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
            Assert.AreEqual("RIGHT", BotCleanLarge.next_move(0, 0, 5, 5, board));
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
            Assert.AreEqual("DOWN", BotCleanLarge.next_move(0, 1, 5, 5, board));
        }

        [TestMethod()]
        public void next_moveTest3()
        {
            var board = new string[]
            {
                "----d",
                "-d---", //-b---
                "--dd-",
                "--d--",
                "----d",
            };
            Assert.AreEqual("RIGHT", BotCleanLarge.next_move(1, 0, 5, 5, board));
        }

        [TestMethod()]
        public void next_moveTest31()
        {
            var board = new string[]
            {
                "----d",
                "-b---",
                "--dd-",
                "--d--",
                "----d",
            };
            Assert.AreEqual("RIGHT", BotCleanLarge.next_move(1, 1, 5, 5, board));
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
            Assert.AreEqual("UP", BotCleanLarge.next_move(2, 1, 5, 5, board));
        }

        [TestMethod()]
        public void next_moveTest4()
        {
            var board = new string[]
            {
                "-----",
                "-----", //-b---
                "d--d-",
                "---d-",
                "--d-d",
            };
            Assert.AreEqual("LEFT", BotCleanLarge.next_move(1, 1, 5, 5, board));
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

            Assert.AreEqual("RIGHT", BotCleanLarge.next_move(1, 1, 5, 5, board));
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
            Assert.AreEqual("LEFT", BotCleanLarge.next_move(1, 1, 5, 5, board));
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
            Assert.AreEqual("DOWN", BotCleanLarge.next_move(1, 0, 5, 5, board));
        }

        [TestMethod()]
        public void next_moveTest41()
        {
            var board = new string[]
            {
                "-d---",
                "-----",
                "d--d-",
                "---d-",
                "--d-d",
            };
            Assert.AreEqual("LEFT", BotCleanLarge.next_move(2, 1, 5, 5, board));
        }

        [TestMethod()]
        public void next_moveTest5()
        {
            var board = new string[]
            {
                "-d---",
                "-d---",
                "-----",
                "---d-",
                "--d-d",
            };
            Assert.AreEqual("DOWN", BotCleanLarge.next_move(2, 3, 5, 5, board));
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
            Assert.AreEqual("LEFT", BotCleanLarge.next_move(3, 3, 5, 5, board));
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
            Assert.AreEqual("RIGHT", BotCleanLarge.next_move(3, 2, 5, 5, board));
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
                "--d-d", //--b--
            };
            Assert.AreEqual("UP", BotCleanLarge.next_move(4, 3, 5, 5, board));
        }
    }
}