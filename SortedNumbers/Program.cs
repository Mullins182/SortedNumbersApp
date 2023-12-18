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
                Console.CursorVisible = false;

                "\n\n\n\n\n\n\n\n\n\t\tPROGRAMM STARTET GLEICH ...".Cprint();

                Thread.Sleep(5000);

                Console.Clear();

                OrderNumbers.unsortList();

                Thread.Sleep(6000);
                Console.Clear();

                OrderNumbers.sortList();
                "\n\n\n\t\t\t\t\t> ".CprintWrite();
                OrderNumbers.sortedNumbers.Min().CintPrint();
                " < ist der kleinste Wert in der Liste !".Cprint();
                "\n\t\t\t\t\t\t\t   UND".Cprint();
                "\n\t\t\t\t\t> ".CprintWrite();
                OrderNumbers.sortedNumbers.Max().CintPrint();
                " < ist der größte Wert in der Liste !".Cprint();

                "\n\n\n\t\t\t\tSORTIEREN ABGESCHLOSSEN ! Beliebige Taste drücken zum beenden !".Cprint();
                input = Console.ReadKey(true).KeyChar;       // Warten auf Eingabe eines Char ...
                                                             // Das Argument vom Typ bool besagt ob der Char in der Console nicht ausgegeb. wird !
            }                                                
            while (input == '*');

        }
    }
}
