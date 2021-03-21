using System;

namespace console_if
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
            else { Console.WriteLine("Try again"); }
        }
    }
}
