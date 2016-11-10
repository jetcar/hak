using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.AI
{
    public class BotSavesPrincess
    {
        public static void displayPathtoPrincess(int n, String[] grid)
        {
            var princessLocationX = -1;
            var princessLocationY = -1;
            var botLocationX = -1;
            var botLocationY = -1;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 'm')
                    {
                        botLocationY = i;
                        botLocationX = j;
                    }
                    if (grid[i][j] == 'p')
                    {
                        princessLocationY = i;
                        princessLocationX = j;
                    }
                }
            }
            var xDifference = botLocationX - princessLocationX;
            var yDifference = botLocationY - princessLocationY;
            for (int i = 0; i < Math.Abs(xDifference); i++)
            {
                if (xDifference > 0)
                {
                    Console.WriteLine("LEFT");
                }
                else
                {
                    Console.WriteLine("RIGHT");
                }
            }
            for (int i = 0; i < Math.Abs(yDifference); i++)
            {
                if (yDifference > 0)
                {
                    Console.WriteLine("UP");
                }
                else
                {
                    Console.WriteLine("DOWN");
                }
            }
        }
    }
}