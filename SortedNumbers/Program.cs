namespace SortedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortTheNumbersandOutputToConsole OrderNumbers = new SortTheNumbersandOutputToConsole();
            char input = '*';

            do
            {
                OrderNumbers.sortedNumbers();
                "\n\n\n\t\t\t\t\t> ".CprintWrite();
                OrderNumbers.unsortedNumbers.Min().CintPrint();
                " < ist der kleinste Wert in der Liste !".Cprint();
                "\n\t\t\t\t\t\t\t   UND".Cprint();
                "\n\t\t\t\t\t> ".CprintWrite();
                OrderNumbers.unsortedNumbers.Max().CintPrint();
                " < ist der größte Wert in der Liste !".Cprint();

                "\n\n\n\t\t\t\tSORTIEREN ABGESCHLOSSEN ! Beliebige Taste drücken zum beenden !".Cprint();
                input = Console.ReadKey(true).KeyChar;                                              // Warten auf Eingabe eines Char ...
            }                                                                                       // Das Argument vom Typ bool besagt ob der Char in der Console nicht ausgegeb. wird !
            while (input == '*');

        }
    }
}
