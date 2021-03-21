using System;

namespace console_var
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = Console.ReadLine();
            int age;
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welcome Mr." + name + " Your Age is. " + age );
        }
    }
}
