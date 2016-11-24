using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.Leet
{
    public class Add_Two_Numbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var iterator1 = l1;
            var iterator2 = l2;
            ListNode result = null;
            ListNode resultIterator = null;
            int pow = 0;
            while (iterator1 != null || iterator2 != null)
            {
                if (iterator1 == null)
                    iterator1 = new ListNode(0);
                if (iterator2 == null)
                    iterator2 = new ListNode(0);
                var value = iterator1.val + iterator2.val + pow;

                if (result == null)
                {
                    result = new ListNode(value % 10);
                    resultIterator = result;
                }
                else
                {
                    resultIterator.next = new ListNode(value % 10);
                    resultIterator = resultIterator.next;
                }
                pow = value / 10;

                iterator1 = iterator1.next;
                iterator2 = iterator2.next;
            }
            while (pow > 0)
            {
                resultIterator.next = new ListNode(pow % 10);
                pow = pow / 10;
            };
            return result;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }
}