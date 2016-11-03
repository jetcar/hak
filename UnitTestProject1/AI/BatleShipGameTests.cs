using hak.AI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject1.AI
{
    /// <summary>
    /// Summary description for BatleShipGameTests
    /// </summary>
    [TestClass]
    public class BatleShipGameTests
    {
        [TestInitialize]
        public void Init()
        {
            BatleShipGame.memoryGrid = null;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var grid = new string[10]
            {
                "----------",
                "----------",
                "--------m-",
                "----------",
                "--d-----m-",
                "---m-m----",
                "------m---",
                "-m---m-hh-",
                "--m-------",
                "------m---",
            };
            BatleShipGame.PlayGame(grid);
            print();
        }

        [TestMethod]
        public void TestMethod5()
        {
            var grid = new string[10]
            {
                "----------",
                "----------",
                "--------m-",
                "----------",
                "--d-----m-",
                "---m-m----",
                "------m---",
                "-m---m--h-",
                "--m-------",
                "------m---",
            };
            BatleShipGame.PlayGame(grid);
            print();
        }

        [TestMethod]
        public void TestMethod2()
        {
            var grid = new string[10]
            {
                "----------",
                "----------",
                "--------m-",
                "----------",
                "--d-----m-",
                "---m-m----",
                "------m-h-",
                "-m---m--h-",
                "--m-------",
                "------m---",
            };
            BatleShipGame.PlayGame(grid);
            print();
        }

        [TestMethod]
        public void TestMethod3()
        {
            var grid = new string[10]
            {
                "----------",
                "----------",
                "--------m-",
                "----------",
                "--d-----m-",
                "---m-m--m-",
                "------m-h-",
                "-m---m--h-",
                "--m-------",
                "------m---",
            };
            BatleShipGame.PlayGame(grid);
            print();
        }

        [TestMethod]
        public void TestMethodEmpty()
        {
            var grid = new string[10]
            {
                "----------",
                "----------",
                "--------m-",
                "----------",
                "--d-----m-",
                "---m-m--m-",
                "------m---",
                "-m---m----",
                "--m-------",
                "------m---",
            };
            BatleShipGame.PlayGame(grid);
            print();
        }

        [TestMethod]
        public void TestDeadShip()
        {
            var grid = new string[10]
            {
                "----------",
                "----------",
                "--------m-",
                "----------",
                "--d-----m-",
                "---m-m--m-",
                "------m---",
                "-m---m----",
                "--m-------",
                "------m---",
            };
            BatleShipGame.PlayGame(grid);
            print();
        }

        [TestMethod]
        public void TestAllCovered()
        {
            var grid = new string[10]
            {
                "----------",
                "-d--d--dd-",
                "--------m-",
                "--d-d-d-d-",
                "--d----dmd",
                "d--mdm-dmd",
                "--d---m--d",
                "-m---m-d--",
                "-dm--d--d-",
                "--d---m---",
            };
            BatleShipGame.PlayGame(grid);
            print();
        }

        [TestMethod]
        public void TestAllCovered2()
        {
            var grid = new string[10]
            {
                "----------",
                "-d--d--dd-",
                "--------m-",
                "d---d-d-d-",
                "-------dmd",
                "d--mdm-dmd",
                "--d---m--d",
                "-m---m-d--",
                "-dm--d--d-",
                "--d---m---",
            };
            BatleShipGame.PlayGame(grid);
            print();
        }

        [TestMethod]
        public void Random()
        {
            var random = new Random();
            Console.WriteLine(random.Next(2));
        }

        [TestMethod]
        public void TestAllCovered3()
        {
            var grid = new string[10]
            {
                "----------",
                "-d--------",
                "---d----m-",
                "d---d-d-d-",
                "-----d-dmd",
                "d--mdm-dmd",
                "--d---md-d",
                "-m---m-d-",
                "-dm--d--d-",
                "--d---m---",
            };
            BatleShipGame.PlayGame(grid);
            print();
        }

        [TestMethod]
        public void TestNearWall()
        {
            var grid = new string[10]
            {
                "----------",
                "----------",
                "h-------m-",
                "----------",
                "--d-----m-",
                "---m-m--m-",
                "------m---",
                "-m---m----",
                "--m-------",
                "------m---",
            };
            BatleShipGame.PlayGame(grid);
            print();
        }

        private static void print()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (BatleShipGame.memoryGrid[j, i] == 0)
                        Console.Write("-,");
                    else
                    {
                        Console.Write(BatleShipGame.memoryGrid[j, i] + ",");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}