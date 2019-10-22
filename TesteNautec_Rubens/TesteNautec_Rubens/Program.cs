using System;

namespace TesteNautec_Rubens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            do
            {
                Console.WriteLine("----------------------------Menu----------------------------");
                Console.Clear();
                Menu menu = new Menu();
                Console.WriteLine(menu);
                string entradadoUsuario = Console.ReadLine();
                menu.ParseAndDestroy(entradadoUsuario);
            } while (true);

        }
    }
}
