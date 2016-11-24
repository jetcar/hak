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
    public class Add_Two_NumbersTests
    {
        [TestMethod()]
        public void AddTwoNumbersTest()
        {
            var l1 = new ListNode(1);
            var l2 = new ListNode(9) { next = new ListNode(9) };
            var res = Add_Two_Numbers.AddTwoNumbers(l1, l2);
            Assert.AreEqual(0, res.val);
            Assert.AreEqual(0, res.next.val);
            Assert.AreEqual(1, res.next.next.val);
        }
    }
}