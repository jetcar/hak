using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.AI
{
    public class BotClean
    {
        public static string next_move(int row, int col, String[] board)
        {
            if (board[row][col] == 'd')
                return "CLEAN";

            var nextx = -1;
            for (int i = row; i < board.Length; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < board[i].Length; j++)
                    {
                        if (board[i][j] == 'd')
                        {
                            if (j == col)
                                continue;
                            if (i == row && j < col)
                                continue;
                            nextx = j;
                            break;
                        }
                    }
                }
                if (i % 2 == 1)
                {
                    for (int j = board[i].Length - 1; j > 0; j--)
                    {
                        if (board[i][j] == 'd')
                        {
                            if (j == col)
                                continue;
                            if (i == row && j > col)
                                continue;

                            nextx = j;
                            break;
                        }
                    }
                }
                if (nextx > -1)
                    break;
            }
            if (nextx > col && row % 2 == 0)
            {
                return "RIGHT";
            }
            if (nextx < col && row % 2 == 1)
            {
                return "LEFT";
            }

            return "DOWN";
        }
    }
}