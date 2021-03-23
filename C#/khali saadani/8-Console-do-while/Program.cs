using System;

namespace _8_Console_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //do
            //{
            //    Console.WriteLine("omar");
            //    i++;
            //}
            //while (i <= 3);
            //=========================================
            //int x = 0;
            //do
            //{
            //    string name;
            //    name = Console.ReadLine();
            //    if (name == "sinan")
            //    {
            //        Console.WriteLine("welcome");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Try again"); x++;
            //    }
            //}
            //while (x <= 3);
            //=========================================
            Console.Write("Please insert your Name: ");
             ask: string name = Console.ReadLine();
            while (name != "admin")
            {
                Console.WriteLine("Try again ");
                goto ask;
            }
            Console.WriteLine("Welcome .. ");

        }
    }
}
