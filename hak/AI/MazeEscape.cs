using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.AI
{
    public class MazeEscape
    {
        private static bool turnRight = false;

        public static void Move(string[] input)
        {
            if (input[0][1] == 'e')
            {
                Console.WriteLine("UP");
            }
            else if (input[1][2] == 'e')
            {
                Console.WriteLine("RIGHT");
            }
            else if (input[2][1] == 'e')
            {
                Console.WriteLine("DOWN");
            }
            else if (input[2][1] == 'e')
            {
                Console.WriteLine("DOWN");
            }
            else if (input[1][0] == 'e')
            {
                Console.WriteLine("LEFT");
            }
            else if (input[0][1] != '#')
            {
                if (input[2][2] == '#' && input[2][2] != '#' && !turnRight)
                {
                    turnRight = true;
                    Console.WriteLine("RIGHT");
                }
                else
                {
                    Console.WriteLine("UP");
                }
            }
            else if (input[1][2] != '#')
            {
                Console.WriteLine("RIGHT");
            }
            else if (input[2][1] != '#')
            {
                Console.WriteLine("DOWN");
            }
            else if (input[2][1] != '#')
            {
                Console.WriteLine("DOWN");
            }
            else if (input[1][0] != '#')
            {
                Console.WriteLine("LEFT");
            }
        }
    }
}