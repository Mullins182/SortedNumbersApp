using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedNumbers
{
    internal class SortTheNumbersandOutputToConsole
    {
        //public List<int> unsortedNumbers = new List<int>()
        //{   505,  888,  203,  744,  216,  449,  197,  500,  284,  548,  159,  845,  159,  949,  691,  981,  324,  563,  854,  468,  117,  465,  502,  413,  232,
        //    645,  848,  646,  549,  765,  225,  437,  681,  2,  44,  362,  845,  895,  627,  43,  708,  883,  950,  268,  814,  747,  689,  568,  504,  234,  781,
        //    780,  574,  759,  937,  95,  761,  934,  936,  523,  459,  55,  698,  551,  111,  649,  499,  879,  77,  446,  89,  503,  917,  1,  988,  435,  689,
        //    797,  950,  885,  501,  706,  84,  771,  782,  380,  916,  484,  525,  135,  495,  265,  428,  389,  662,  411,  876,  604, 650, 915
        //};

        public List<int> sortedNumbers = new List<int>()
        {   1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
            41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78,
            79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100
        };

        public SortTheNumbersandOutputToConsole() { }

        public List<int> sortList()
        {
            Console.CursorVisible = false;

            for(int n = 100; n > 0; n--)
            {
                Functions.NewLinesAndCLSoutput();

                "\t\t\t\t      DIE LISTE 1 bis 100 WIRD JETZT WIEDER SORTIERT !".Cprint();

                for (int i = 0; i < sortedNumbers.Count() - 1; i++)
                {

                    int buffer = sortedNumbers[i];

                    if (buffer > sortedNumbers[i + 1])
                    {

                        sortedNumbers[i] = sortedNumbers[i + 1];
                        sortedNumbers[i + 1] = buffer;
                    }

                    if (i % 10 == 0)
                    {
                        Console.WriteLine();
                        Console.Write("\t\t\t");
                        //Console.Write($"{i:5}");
                        sortedNumbers[i].CintPrint();
                        //"\t".CprintWrite();
                    }
                    else
                    {
                        //Console.Write("{i:5}");
                        sortedNumbers[i].CintPrint();
                        //"\t".CprintWrite();
                    }
                }

                sortedNumbers[sortedNumbers.Count()-1].CintPrint();

                Thread.Sleep(250);
            }

            return sortedNumbers;            
        }

        public List<int> unsortList()
        {
            var n = 0;
            var z = 0;
            int buffer = 0;
            var generateRandoms = new Random();                                     // Neue Instanz der Random Klasse erstellen !
                                                                                    // GenerateRandoms.Next() = Zufallszahl zwischen (x, y) erzeugen !
            for (int i = 100; i > 0; i--)
            {
                Console.Clear();

                Functions.NewLinesAndCLSoutput();

                "\t\t\t\t      LISTE 1 bis 100 WIRD DURCHEINANDER GEWIRBELT ^^".Cprint();


                for (int j = 0; j <= sortedNumbers.Count() - 1; j++)
                {
                    n       = generateRandoms.Next(0, 100);
                    buffer  = sortedNumbers[n];
                    z       = generateRandoms.Next(0, 100);

                    sortedNumbers[n] = sortedNumbers[z];
                    sortedNumbers[z] = buffer;

                    if (j % 10 == 0)
                    {
                        Console.WriteLine();
                        Console.Write("\t\t\t");
                        sortedNumbers[j].CintPrint();
                        //"\t".CprintWrite();
                    }
                    else
                    {
                        sortedNumbers[j].CintPrint();
                        //"\t".CprintWrite();
                    }                    
                }

                //sortedNumbers[sortedNumbers.Count() - 1].CintPrint();
                Thread.Sleep(5);
            }

            return sortedNumbers;
        }
    }
}
