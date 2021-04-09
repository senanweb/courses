using System;

namespace _7_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3] {"a", "b", "c"};
           
            //view array
            int i = 0;
            while (i < names.LongLength)
            {
                Console.WriteLine(names[i]);
                i++;
            }
            //
            Console.WriteLine(names.Length); //how many in the array
        }
    }
}
