using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.Strings
{
    public class CamelCase
    {
        public static void Count(string str)
        {
            var count = 1;
            for (int i = 1; i < str.Length; i++)
            {
                var charValue = str[i];
                if (char.IsUpper(charValue))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}