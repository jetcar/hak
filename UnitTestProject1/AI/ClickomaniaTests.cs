using hak.AI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1.AI
{
    /// <summary>
    /// Summary description for ClickomaniaTests
    /// </summary>
    [TestClass]
    public class ClickomaniaTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var input = new[]
            {
"BBRBRBRBBB",
"RBRBRBBRRR",
"RRRBBRBRRR",
"RBRBRRRBBB",
"RBRBRRRRBB",
"RBBRBRRRRR",
"BBRBRRBRBR",
"BRBRBBRBBB",
"RBBRRRRRRB",
"BBRBRRBBRB",
"BBBRBRRRBB",
"BRBRRBRRBB",
"BRRBBBBBRB",
"RRBBRRBRRR",
"RRRBRRRBBB",
"RRRRRBBBRR",
"BRRRBRRRBB",
"BBBBRBRRRB",
"BRBBBBBRBB",
"RRRRRBBRRR"
            };

            ClickoMania.nextMove(20, 10, 2, input);
        }
    }
}