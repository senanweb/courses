using System;

namespace Console_name_age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please Insert your Name: ");
            string name;
            name = Console.ReadLine();
            // we input data type string
            //==================================
            Console.Write("please Insert your Age: ");
            int age;
            age = Convert.ToInt32(Console.ReadLine());
            // we input data type int
            //==================================
            //Console.WriteLine("Welcome Mr." + name + " Your Age is. " + age ); //one way to view
            //Console.WriteLine("Welcome Mr.{0}, Your Age is.{1}", name, age);  // second way
            Console.WriteLine($"Welcome Mr. {name} and your Age is {age}");    // third way
            // here we view the data
        }
    }
}
