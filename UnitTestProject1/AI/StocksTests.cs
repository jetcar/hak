using hak.AI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1.AI
{
    [TestClass()]
    public class StocksTests
    {
        [TestMethod()]
        public void PrintTransactionsTest()
        {
            var stocks = new string[]
            {
                "iStreet",
                "HR"
            };
            var own = new int[]
            {
                10, 0
            };
            var prices = new double[,]
            {
                {4.54, 5.53, 6.56, 5.54, 7.60},
                {30.54, 27.53, 24.42, 20.11, 17.50}
            };
            Stocks.printTransactions(90, 2, 400, stocks, own, prices);
        }

        [TestMethod()]
        public void PrintTransactionsTest2()
        {
            var stocks = new string[]
            {
                "CAL",
                "UCB",
                "RIT",
                "UCLA",
                "USC",
                "UFL",
                "UMAD",
                "RICE",
                "UMD",
                "UCSC",
            };
            var own = new int[]
            {
                0, 0,0,0,0,0,0,0,0,0
            };
            var prices = new double[,]
            {
                {121.83, 122.26, 123.94, 122.11, 120.58},
              { 52.34, 50.89, 47.62 ,51.16 ,52.4},
 { 100.21 ,99.33, 102.87 ,110.63 ,110.72},
 {  12.5, 27.22 ,9.32 ,16.07, 3.86},
 {  249.58 ,244.24 ,242.56 ,245.13 ,245.35},
 { 20.21 ,19.77 ,21.34, 20.21, 21.17},
 {  109.39 ,120.49 ,131.35 ,127.97 ,121.38},
 { 126.3, 128, 129.08, 129.28 ,124.44},
 {  102.96, 103.62, 98.22, 96.6, 99.1},
 {  213.77, 193.51, 178.53, 180.08 ,208.29},
            };
            Stocks.printTransactions(100, 10, 20, stocks, own, prices);
        }
    }
}