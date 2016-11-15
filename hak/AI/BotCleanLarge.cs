using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.AI
{
    public class BotCleanLarge
    {
        public static string next_move(int posr, int posc, int dimh, int dimw, String[] board)
        {
            List<Tuple<int, int>> points = new List<Tuple<int, int>>();
            for (int i = 0; i < board.Length; i++)
            {
                var line = board[i];
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == 'd')
                    {
                        if (j == posc && posr == i)
                        {
                            return "CLEAN";
                        }
                        points.Add(new Tuple<int, int>(i, j));
                    }
                }
            }
            var differences = new List<int>();
            foreach (var point in points)
            {
                differences.Add(Math.Abs(posr - point.Item1) + Math.Abs(posc - point.Item2));
            }
            var min = dimh + dimw;
            var minIndex = differences.Count;
            for (int i = 0; i < differences.Count; i++)
            {
                if (differences[i] < min)
                {
                    min = differences[i];
                    minIndex = i;
                }
            }
            var minpoint = points[minIndex];
            if (posc > minpoint.Item2)
            {
                return "LEFT";
            }
            if (posc < minpoint.Item2)
            {
                return "RIGHT";
            }
            if (posr < minpoint.Item1)
            {
                return "DOWN";
            }

            return "UP";
        }
    }
}