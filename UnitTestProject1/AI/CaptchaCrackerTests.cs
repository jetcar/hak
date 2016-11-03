using hak.AI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.AI
{
    [TestClass]
    public class CaptchaCrackerTests
    {
        [TestMethod]
        [DeploymentItem("ai\\input\\input00.txt")]
        public void Test00()
        {
            StreamReader sr = new StreamReader("input00.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input01.txt")]
        public void Test01()
        {
            StreamReader sr = new StreamReader("input01.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input02.txt")]
        public void Test02()
        {
            StreamReader sr = new StreamReader("input02.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input03.txt")]
        public void Test03()
        {
            StreamReader sr = new StreamReader("input03.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input04.txt")]
        public void Test04()
        {
            StreamReader sr = new StreamReader("input04.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input05.txt")]
        public void Test05()
        {
            StreamReader sr = new StreamReader("input05.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input06.txt")]
        public void Test06()
        {
            StreamReader sr = new StreamReader("input06.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input07.txt")]
        public void Test07()
        {
            StreamReader sr = new StreamReader("input07.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input08.txt")]
        public void Test08()
        {
            StreamReader sr = new StreamReader("input08.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input09.txt")]
        public void Test09()
        {
            StreamReader sr = new StreamReader("input09.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input10.txt")]
        public void Test10()
        {
            StreamReader sr = new StreamReader("input10.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input11.txt")]
        public void Test11()
        {
            StreamReader sr = new StreamReader("input11.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input12.txt")]
        public void Test12()
        {
            StreamReader sr = new StreamReader("input12.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input13.txt")]
        public void Test13()
        {
            StreamReader sr = new StreamReader("input13.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input14.txt")]
        public void Test14()
        {
            StreamReader sr = new StreamReader("input14.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input15.txt")]
        public void Test15()
        {
            StreamReader sr = new StreamReader("input15.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input16.txt")]
        public void Test16()
        {
            StreamReader sr = new StreamReader("input16.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input17.txt")]
        public void Test17()
        {
            StreamReader sr = new StreamReader("input17.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input18.txt")]
        public void Test18()
        {
            StreamReader sr = new StreamReader("input18.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input19.txt")]
        public void Test19()
        {
            StreamReader sr = new StreamReader("input19.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input20.txt")]
        public void Test20()
        {
            StreamReader sr = new StreamReader("input20.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input21.txt")]
        public void Test21()
        {
            StreamReader sr = new StreamReader("input21.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input22.txt")]
        public void Test22()
        {
            StreamReader sr = new StreamReader("input22.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input23.txt")]
        public void Test23()
        {
            StreamReader sr = new StreamReader("input23.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\input24.txt")]
        public void Test24()
        {
            StreamReader sr = new StreamReader("input24.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\TextFile1.txt")]
        public void Test25()
        {
            StreamReader sr = new StreamReader("TextFile1.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\TextFile2.txt")]
        public void Test26()
        {
            StreamReader sr = new StreamReader("TextFile2.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\TextFile3.txt")]
        public void Test27()
        {
            StreamReader sr = new StreamReader("TextFile3.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }

        [TestMethod]
        [DeploymentItem("ai\\input\\TextFile4.txt")]
        public void Test28()
        {
            StreamReader sr = new StreamReader("TextFile4.txt");

            string[] input = new string[30];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = sr.ReadLine();
            }

            CaptchaCracker.Crack(input);
        }
    }
}