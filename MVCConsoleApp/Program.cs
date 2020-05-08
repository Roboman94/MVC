using System;

namespace MVCConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController c = new CountryController();
            c.WelcomeAction();
            while (true)
            {
                Console.WriteLine("Would you like to learn about another country? (y/n)");
                string answer = Console.ReadLine().Trim().ToLower();
                if (answer == "y")
                {
                    Console.WriteLine();
                    c.SecondAction();
                }
                if (answer == "n")
                {

                    Console.WriteLine("GoodBye!");
                    break;
                }
                    
                    
            }
        }
    }
}
