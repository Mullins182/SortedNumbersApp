using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedNumbers
{
    internal class SortTheNumbersandOutputToConsole
    {
        
        public List<int> unsortedNumbers = new List<int>()
        { 12, 55, 944, 35, 751, 654, 1044, 977, 864, 85, 11, 5, 1, 357, 1111, 266, 523, 933, 764, 841, 513, 632, 27, 2733, 3, 24, 57, 31, 21, 88,
          22, 720, 560, 666, 121, 5999, 517, 844, 852, 369
        };
        public SortTheNumbersandOutputToConsole() { }

        public List<int> sortedNumbers()
        {
            Console.CursorVisible = false;

            for(int n = 25; n > 0; n--)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                for (int i = 0; i < unsortedNumbers.Count() - 1; i++)
                {

                    int buffer = unsortedNumbers[i];

                    if (buffer > unsortedNumbers[i + 1])
                    {

                        unsortedNumbers[i] = unsortedNumbers[i + 1];
                        unsortedNumbers[i + 1] = buffer;
                    }

                    if (i % 10 == 0)
                    {
                        Console.WriteLine();
                        Console.Write("\t\t\t");
                        unsortedNumbers[i].CintPrint();
                        "\t".CprintWrite();
                    }
                    else
                    {
                        unsortedNumbers[i].CintPrint();
                        "\t".CprintWrite();
                    }
                }

                unsortedNumbers[unsortedNumbers.Count()-1].CintPrint();

                Thread.Sleep(500);
            }

            return unsortedNumbers;            
        }
    }
}
