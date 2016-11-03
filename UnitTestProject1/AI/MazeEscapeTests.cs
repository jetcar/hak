using hak.AI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1.AI
{
    /// <summary>
    /// Summary description for MazeEscapeTests
    /// </summary>
    [TestClass]
    public class MazeEscapeTests
    {
        [TestMethod]
        public void TestMethod1Right()
        {
            var input = new[]
            {
                "###",
                "#b-",
                "#--",
            };
            MazeEscape.Move(input);
        }

        [TestMethod]
        public void TestMethodDown()
        {
            var input = new[]
            {
                "--#",
                "--#",
                "--#",
            };
            MazeEscape.Move(input);
        }

        [TestMethod]
        public void TestMethodUP()
        {
            var input = new[]
            {
                "#--",
                "#--",
                "#--",
            };
            MazeEscape.Move(input);
        }
    }
}