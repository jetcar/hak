using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1.Algoritms
{
    /// <summary>
    /// Summary description for StairCase
    /// </summary>
    [TestClass]
    public class StairCase
    {
        [TestMethod]
        public void TestMethod1()
        {
            var n = 6;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (n - 2 - j < i)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}