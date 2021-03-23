using System;

namespace Console_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert your First number: ");
            int num1;
            num1 = Convert.ToInt32(Console.ReadLine());
            //==========================
            Console.Write("Please insert your Second number: ");
            int num2;
            num2 = Convert.ToInt32(Console.ReadLine());
            //==========================
            int sum;
            sum = num1 + num2;
            //==========================
            Console.Write("Please insert your Div number: ");
            int num3;
            num3 = Convert.ToInt32(Console.ReadLine());
            //==========================
            int result;
            result = sum / num3  ;
            //==========================
            Console.WriteLine($"Your Total is: {result}");
            //================================
           
        }
    }
}
