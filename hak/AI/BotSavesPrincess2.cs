using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.AI
{
    public class BotSavesPrincess2
    {
        public static void nextMove(int n, int r, int c, String[] grid)
        {
            var princessLocationX = -1;
            var princessLocationY = -1;
            var botLocationX = c;
            var botLocationY = r;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 'p')
                    {
                        princessLocationY = i;
                        princessLocationX = j;
                    }
                }
            }
            var xDifference = botLocationX - princessLocationX;
            var yDifference = botLocationY - princessLocationY;

            if (xDifference > 0)
            {
                Console.WriteLine("LEFT");
                return;
            }
            else if (xDifference < 0)
            {
                Console.WriteLine("RIGHТ");
                return;
            }

            if (yDifference > 0)
            {
                Console.WriteLine("UP");
                return;
            }
            else if (yDifference < 0)
            {
                Console.WriteLine("DOWN");
                return;
            }
        }
    }
}