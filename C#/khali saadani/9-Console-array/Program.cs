using System;

namespace _9_Console_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[3] { "Nadom", "Arkan", "Omar" };
            
            Console.WriteLine(name[0]);
            int i = 0;
            for (i = 0; i<name.Length ; i++)
            {
                Console.WriteLine($"Welcome Mr. {name[i]}");
            }
            
        }
    }
}
