using System;

namespace _8_function
{
    class Program
    {
        static int _acount (int x, int y)
        {
           int s = x + y;
           int tot = s / 2;
            return tot;
        }
        static void Main(string[] args) //this is function
        {
            int tot = _acount(7, 3);
            Console.WriteLine(tot);
        }
    }
}
