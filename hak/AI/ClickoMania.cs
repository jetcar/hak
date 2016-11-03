using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.AI
{
    public class ClickoMania
    {
        public static void nextMove(int x, int y, int color, string[] grid)
        {
            var indexes = new int[grid.Length, grid[0].Length];

            var min = 100;
            var maxX = 0;
            var maxY = 0;

            for (int i = grid.Length - 1; i >= 0; i--)
            {
                var line = grid[i];
                for (int j = line.Length - 1; j >= 0; j--)
                {
                    if (grid[i][j] == '-')
                        continue;
                    var value = calculate(indexes, grid, j, i, grid[i][j]);
                    //Console.Write(indexes[i, j] + ",");
                    indexes = new int[grid.Length, grid[0].Length];
                    if (value > min && value % 2 == 0)
                    {
                        min = value;
                        maxX = j;
                        maxY = i;
                    }
                    if (maxY == 0 && maxX == 0 && value > 1)
                    {
                        maxX = j;
                        maxY = i;
                    }
                }
            }
            Console.WriteLine(maxY + " " + maxX);
        }

        public static int calculate(int[,] indexes, string[] input, int startx, int starty, char symbol)
        {
            if (startx < 0 || startx > input[0].Length - 1)
                return 0;
            if (starty < 0 || starty > input.Length - 1)
                return 0;
            if (indexes[starty, startx] == -1)
                return 0;
            indexes[starty, startx] = -1;

            if (input[starty][startx] != symbol)
                return 0;
            if (input[starty][startx] == symbol)
                return 1 + calculate(indexes, input, startx - 1, starty, symbol)
                       + calculate(indexes, input, startx, starty - 1, symbol)
                       + calculate(indexes, input, startx + 1, starty, symbol)
                       + calculate(indexes, input, startx, starty + 1, symbol);
            return 0;
        }
    }
}