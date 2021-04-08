using System;

namespace _4_logical
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, tot;
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = n1 + n2;
            tot = n3 / 2;
            Console.WriteLine($"your input is = {tot}");
            Console.WriteLine("==================");
        }
    }
}
