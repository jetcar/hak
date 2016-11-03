using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.AI
{
    public class BatleShipGame
    {
        public static char[,] memoryGrid = null;
        private static Random random = new Random();

        public static void PlayGame(string[] grid)
        {
            var hitShipAmount = 0;
            var hitShipX = 0;
            var hitShipY = 0;
            var hitShipEndX = 0;
            var hitShipEndY = 0;
            if (memoryGrid == null)
            {
                memoryGrid = new char[grid.Length, grid.Length];
            }
            for (int i = 0; i < grid.Length; i++)
            {
                var line = grid[i];
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == 'm')
                    {
                        memoryGrid[j, i] = 'm';
                    }
                    if (line[j] == 'h')
                    {
                        memoryGrid[j, i] = 'h';

                        MarkAsNotNeeded(grid, memoryGrid, j + 1, i - 1);
                        MarkAsNotNeeded(grid, memoryGrid, j + 1, i + 1);
                        MarkAsNotNeeded(grid, memoryGrid, j - 1, i - 1);
                        MarkAsNotNeeded(grid, memoryGrid, j - 1, i + 1);

                        hitShipAmount++;
                        if (hitShipAmount == 1)
                        {
                            hitShipX = j;
                            hitShipY = i;
                        }
                        hitShipEndX = j;
                        hitShipEndY = i;
                    }
                    if (line[j] == 'd')
                    {
                        memoryGrid[j, i] = 'd';
                        MarkAsNotNeeded(grid, memoryGrid, j + 1, i - 1);
                        MarkAsNotNeeded(grid, memoryGrid, j + 1, i);
                        MarkAsNotNeeded(grid, memoryGrid, j + 1, i + 1);

                        MarkAsNotNeeded(grid, memoryGrid, j, i - 1);
                        MarkAsNotNeeded(grid, memoryGrid, j, i + 1);

                        MarkAsNotNeeded(grid, memoryGrid, j - 1, i - 1);
                        MarkAsNotNeeded(grid, memoryGrid, j - 1, i);
                        MarkAsNotNeeded(grid, memoryGrid, j - 1, i + 1);
                    }
                }
            }

            if (hitShipAmount == 1)
            {
                if (CanHitHere(grid, memoryGrid, hitShipX - 1, hitShipY))
                {
                    WriteLine((hitShipX - 1), (hitShipY));
                    return;
                }

                if (CanHitHere(grid, memoryGrid, hitShipX + 1, hitShipY))
                {
                    WriteLine((hitShipX + 1), (hitShipY));
                    return;
                }

                if (CanHitHere(grid, memoryGrid, hitShipX, hitShipY - 1))
                {
                    WriteLine((hitShipX), (hitShipY - 1));
                    return;
                }

                if (CanHitHere(grid, memoryGrid, hitShipX, hitShipY + 1))
                {
                    WriteLine((hitShipX), (hitShipY + 1));
                    return;
                }
            }
            else if (hitShipAmount > 1)
            {
                //start
                if (CanHitHere(grid, memoryGrid, hitShipX - 1, hitShipY))
                {
                    WriteLine((hitShipX - 1), (hitShipY));
                    return;
                }

                if (CanHitHere(grid, memoryGrid, hitShipX + 1, hitShipY))
                {
                    WriteLine((hitShipX + 1), (hitShipY));
                    return;
                }

                if (CanHitHere(grid, memoryGrid, hitShipX, hitShipY - 1))
                {
                    WriteLine((hitShipX), (hitShipY - 1));
                    return;
                }

                if (CanHitHere(grid, memoryGrid, hitShipX, hitShipY + 1))
                {
                    WriteLine((hitShipX), (hitShipY + 1));
                    return;
                }

                //end

                if (CanHitHere(grid, memoryGrid, hitShipEndX - 1, hitShipEndY))
                {
                    WriteLine((hitShipEndX - 1), (hitShipEndY));
                    return;
                }

                if (CanHitHere(grid, memoryGrid, hitShipEndX + 1, hitShipEndY))
                {
                    WriteLine((hitShipEndX + 1), (hitShipEndY));
                    return;
                }

                if (CanHitHere(grid, memoryGrid, hitShipEndX, hitShipEndY - 1))
                {
                    WriteLine((hitShipEndX), (hitShipEndY - 1));
                    return;
                }

                if (CanHitHere(grid, memoryGrid, hitShipEndX, hitShipEndY + 1))
                {
                    WriteLine((hitShipEndX), (hitShipEndY + 1));
                    return;
                }
            }

            var availablePoints = new List<string>();

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (CanHitHere(grid, memoryGrid, j, i))
                    {
                        availablePoints.Add(i + " " + j);
                    }
                }
            }
            Console.WriteLine(availablePoints[random.Next(0, availablePoints.Count)]);
        }

        private static void WriteLine(int x, int y)
        {
            Console.WriteLine((y) + " " + (x));
        }

        private static bool CanHitHere(string[] grid, char[,] myGrid, int x, int y)
        {
            if (y < 0)
                return false;
            if (x < 0)
                return false;
            if (y >= grid.Length)
                return false;
            if (x >= grid[y].Length)
                return false;
            if (myGrid[x, y] == 0)
                return true;
            return false;
        }

        private static void MarkAsNotNeeded(string[] grid, char[,] myGrid, int x, int y)
        {
            if (y < 0)
                return;
            if (x < 0)
                return;
            if (y >= grid.Length)
                return;
            if (x >= grid[y].Length)
                return;
            if (myGrid[x, y] == 0)
                myGrid[x, y] = 'x';
        }
    }
}