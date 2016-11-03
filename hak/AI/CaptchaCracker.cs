using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hak.AI
{
    public class CaptchaCracker
    {
        public static void Crack(string[] input)
        {
            int[][] packedColors = new int[input.Length][];
            for (int i = 0; i < input.Length; i++)
            {
                var line = input[i];
                var columns = line.Split(' ');
                packedColors[i] = new int[columns.Length];
                for (int j = 0; j < columns.Length; j++)
                {
                    var sum = 0;
                    foreach (string number in columns[j].Split(','))
                    {
                        sum += Convert.ToInt32(number);
                    }
                    if (sum <= 93)
                        sum = 0;
                    packedColors[i][j] = sum;
                }
            }
            //print(packedColors);

            CutArray(packedColors);
        }

        private static void CutArray(int[][] packedColors)
        {
            for (int i = 0; i < packedColors.Length; i++)
            {
                for (int j = 0; j < packedColors[i].Length; j++)
                {
                    if (packedColors[i][j] == 0)
                    {
                        var vector = calculate(packedColors, j, i);
                        switch (vector)
                        {
                            case -52768055:
                                Console.Write("E");
                                break;

                            case -1930481119:
                                Console.Write("R");
                                break;

                            case 1747649522:
                                Console.Write("C");
                                break;

                            case -2044750247:
                                Console.Write("3");
                                break;

                            case -2126213683:
                                Console.Write("G");
                                break;

                            case -648387820:
                                Console.Write("Y");
                                break;

                            case 293938770:
                                Console.Write("K");
                                break;

                            case 1412283660:
                                Console.Write("4");
                                break;

                            case 1653095948:
                                Console.Write("1");
                                break;

                            case -1178407390:
                                Console.Write("2");
                                break;

                            case 1140709321:
                                Console.Write("5");
                                break;

                            case -796638731:
                                Console.Write("6");
                                break;

                            case 1361420988:
                                Console.Write("7");
                                break;

                            case 815360780:
                                Console.Write("9");
                                break;

                            case -1370831904:
                                Console.Write("O");
                                break;

                            case -1292064830:
                                Console.Write("W");
                                break;

                            case 854778154:
                                Console.Write("V");
                                break;

                            case -1974566718:
                                Console.Write("L");
                                break;

                            case -1760369968:
                                Console.Write("I");
                                break;

                            case 240035832:
                                Console.Write("J");
                                break;

                            case -714822080:
                                Console.Write("Q");
                                break;

                            case -1377401026:
                                Console.Write("T");
                                break;

                            case 353368668:
                                Console.Write("A");
                                break;

                            case -2031671066:
                            case 398255974:
                                Console.Write("D");
                                break;

                            case 1288426431:
                                Console.Write("Z");
                                break;

                            case -1276280980:
                                Console.Write("M");
                                break;

                            case 543696706:
                                Console.Write("U");
                                break;

                            case 1688068876:
                                Console.Write("N");
                                break;

                            case 359571084:
                                Console.Write("9");
                                break;

                            case 955771894:
                                Console.Write("F");
                                break;

                            case 1003733596:
                                Console.Write("0");
                                break;

                            case -446631712:
                                Console.Write("0");
                                break;

                            case 1182967218:
                                Console.Write("H");
                                break;

                            case -332025910:
                                Console.Write("8");
                                break;

                            case 57587802:
                                Console.Write("S");
                                break;

                            case 1364412224:
                                Console.Write("B");
                                break;

                            case -2028439678:
                                Console.Write("K");
                                break;

                            case 49377825:
                                Console.Write("P");
                                break;

                            case 317081108:
                                Console.Write("X");
                                break;

                            default:
                                Console.WriteLine(vector);
                                break;
                        }

                        //print(packedColors);
                    }
                }
            }
            Console.WriteLine();
        }

        public static int calculate(int[][] input, int startx, int starty)
        {
            if (startx < 0 || startx > input[0].Length - 1)
                return 0;
            if (starty < 0 || starty > input.Length - 1)
                return 0;

            if (input[starty][startx] != 0)
                return 0;
            input[starty][startx] = -1;

            return 1
                + calculate(input, startx - 1, starty - 1) * 1
                + calculate(input, startx, starty - 1) * 2
                + calculate(input, startx + 1, starty - 1) * 3

                   + calculate(input, startx - 1, starty) * 4
                   + calculate(input, startx + 1, starty) * 5

                   + calculate(input, startx - 1, starty + 1) * 6
                   + calculate(input, startx, starty + 1) * 7
                   + calculate(input, startx + 1, starty + 1) * 8;
        }
    }
}