using System;

namespace if_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = Console.ReadLine();
            if (name == "sinan")
            {
                Console.WriteLine("Hello World!");
            }
            else if (name == "omar")
            { 
                Console.WriteLine("Welcome to world"); 
            }
            else 
            {
                Console.WriteLine("try again");
            }
        }
    }
}
