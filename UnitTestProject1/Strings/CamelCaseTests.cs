using hak.Strings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1.Strings
{
    /// <summary>
    /// Summary description for CamelCaseTests
    /// </summary>
    [TestClass]
    public class CamelCaseTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            CamelCase.Count("saveChangesInTheEditor");
        }
    }
}