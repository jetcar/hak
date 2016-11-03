using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.AI
{
    public class Stocks
    {
        private static double[] myprices = null;

        public static void printTransactions(double money, int k, int d, String[] names, int[] owned, double[,] prices)
        {
            if (myprices == null)
                myprices = new double[names.Length];
            var output = new List<string>();
            var bestPriceIndex = 0;
            var difference = 0.0;
            for (int i = 0; i < names.Length; i++)
            {
                var average = calculateAverage(prices, i);
                var lastPrice = GetLastPrice(prices, i);
                if (owned[i] > 0 && lastPrice > average && lastPrice > myprices[i])
                {
                    output.Add(names[i] + " SELL " + owned[i]);
                }
                if (lastPrice < average)
                {
                    if (difference < average - lastPrice)
                    {
                        difference = average - lastPrice;
                        bestPriceIndex = i;
                    }
                }
            }

            var price = GetLastPrice(prices, bestPriceIndex);

            if (money > 0)
            {
                int amount = (int)(money / price);
                if (amount > 0)
                    output.Add(names[bestPriceIndex] + " BUY " + amount);
            }
            Console.WriteLine(output.Count);
            foreach (var line in output)
            {
                Console.WriteLine(line);
            }
        }

        private static double GetLastPrice(double[,] prices, int index)
        {
            return prices[index, prices.GetLength(1) - 1];
        }

        public static double calculateAverage(double[,] prices, int index)
        {
            var average = 0.0;
            var sum = 0.0;
            for (int i = 0; i < prices.GetLength(1); i++)
            {
                sum += prices[index, i];
            }
            return sum / (double)prices.GetLength(1);
        }
    }
}