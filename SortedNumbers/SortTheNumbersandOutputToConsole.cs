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
        {   683,  888,  203,  744,  216,  449,  197,  41,  284,  548,  159,  845,  159,  949,  691,  981,  324,  563,  854,  468,  117,  465,  808,  413,  232,
            645,  848,  646,  549,  765,  225,  437,  681,  2,  44,  362,  845,  895,  627,  43,  708,  883,  950,  268,  814,  747,  689,  568,  917,  234,  781,
            780,  574,  759,  937,  95,  761,  934,  936,  523,  459,  55,  698,  551,  111,  649,  499,  879,  77,  446,  89,  117,  917,  926,  988,  435,  689,
            797,  950,  885,  718,  706,  84,  771,  782,  380,  916,  484,  525,  135,  495,  265,  428,  389,  662,  411,  876,  604, 650, 915
        };
        public SortTheNumbersandOutputToConsole() { }

        public List<int> sortedNumbers()
        {
            Console.CursorVisible = false;

            for(int n = 85; n > 0; n--)
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

                Thread.Sleep(25);
            }

            return unsortedNumbers;            
        }
    }
}
