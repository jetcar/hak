using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.AI
{
    public class LightsOut
    {
        public static void nextMove(int player, String[] board)
        {
            var indexes = new int[board.Length, board[0].Length];

            for (int i = 0; i < board.Length; i++)
            {
                var line = board[i];
                for (int j = 0; j < line.Length; j++)
                {
                    if (board[i][j] == '0')
                    {
                        continue;
                    }
                    var value = calculate(indexes, board, j, i, '1');
                    //Console.Write(value + ",");

                    if (value > 2)
                    {
                        Console.WriteLine(i + " " + (j + 1));
                        return;
                    }
                    indexes = new int[board.Length, board[0].Length];
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                var line = board[i];
                for (int j = 0; j < line.Length; j++)
                {
                    if (board[i][j] == '0')
                    {
                        continue;
                    }
                    var value = calculate(indexes, board, j, i, '1');
                    //Console.Write(value + ",");

                    if (value > 2)
                    {
                        Console.WriteLine(i + " " + (j + 1));
                        return;
                    }
                    indexes = new int[board.Length, board[0].Length];
                }
            }
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

            if (input[starty][startx] != '1')
                return 0;
            if (input[starty][startx] == symbol)
                return 1 + calculate(indexes, input, startx - 1, starty, symbol)
                       + calculate(indexes, input, startx + 1, starty, symbol);
            return 0;
        }
    }
}