using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class Utils
    {
        public static void print(int[][] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                var line = input[i];
                for (int j = 0; j < line.Length; j++)
                {
                    Console.Write(line[j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}