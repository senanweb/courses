using System;

namespace _5_condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input your name : ");
            string name;
            name = Console.ReadLine();
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
    }
}
