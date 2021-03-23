using System;

namespace Console_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            switch (name )
            {
                case "Nadom":
                    Console.WriteLine("Name my Father");
                    break;
                case "Omar":
                    Console.WriteLine("Name my son");
                    break;
                default:
                    Console.WriteLine("this is my Name");
                    break;
            }
        }
    }
}
