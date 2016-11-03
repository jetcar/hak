using hak.AI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1.AI
{
    /// <summary>
    /// Summary description for LightsOutTests
    /// </summary>
    [TestClass]
    public class LightsOutTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var board = new[]
            {
                "01101100",
"01010101",
"10111100",
"00001111",
"10101010",
"00000001",
"11100011",
"00101000",
            };
            LightsOut.nextMove(1, board);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var board = new[]
            {
"01010000",
            };
            LightsOut.nextMove(1, board);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var board = new[]
            {
"01110000",
            };
            LightsOut.nextMove(1, board);
        }
    }
}