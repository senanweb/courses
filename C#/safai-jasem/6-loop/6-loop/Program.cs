using System;

namespace _6_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //for
            int x = 0;
            for (x=0;x<=5;x++)
            {
                Console.Write("Please input your name : ");
                string name;
                name = Console.ReadLine();
                // input name
                if (name == "senan")
                {
                    Console.WriteLine($"Welcome to our Applcation {name }"); // part one
                }
                else if (name == "omar")
                {
                    Console.WriteLine($"Welcome to our Applcation {name }"); //part tow
                }
                else
                {
                    Console.WriteLine("Please contact the Admin page"); // part three
                }
            }
            //for
            Console.WriteLine("============================");
            //while

        }
    }
}
