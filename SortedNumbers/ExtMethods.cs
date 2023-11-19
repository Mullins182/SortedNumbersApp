using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SortedNumbers
{
    internal static class ExtMethods
    {
        public static string Cprint(this string x)              // Extended Method to output strings in console
        {
            Console.WriteLine(x);
            return x;
        }

        public static int CintPrint(this int x)                 // Extended Method to print any Integer to console and even calculate and print Numbers
        {                                                       // Example: (15+56-17).CintPrint() ... outputs the calculation result in the console.
            Console.WriteLine(x);
            return x;
        }
    }
}
