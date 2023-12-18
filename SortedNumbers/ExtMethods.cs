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
        public static void Cprint(this string x)                   // Extended Method to output strings in console
        {
            Console.WriteLine(x);
        }

        public static void CprintWrite(this string x)             // Print in actual Line Ext. Method
        {
            Console.Write(x);
        }

        public static void CintPrint(this int x)                 // Extended Method to print any Integer to console and even calculate and print Numbers
        {
                                                                // Example: (15+56-17).CintPrint() ... outputs the calculation result in the console.
            Console.Write(x);
        }
    }
}
