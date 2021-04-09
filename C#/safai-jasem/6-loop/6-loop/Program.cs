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
                Console.WriteLine(x);
            }
            //for
            Console.WriteLine("============================");
            //while
            int i = 0;
            while (i<=2)
            {
                //name
                Console.Write("Please input your name : ");
                string name;
                name = Console.ReadLine();
                //pass
                Console.Write("Please input your pass : ");
                int pass;
                pass = Convert .ToInt32 (Console.ReadLine());
                if (name == "senan" & pass == 1977)
                {
                    Console.WriteLine($"Welcome to our Applcation {name }"); // part one
                    break;
                }
                else if (name == "omar" & pass == 2011)
                {
                    Console.WriteLine($"Welcome to our Applcation {name }"); //part tow
                    break;
                }
                else
                {
                    Console.WriteLine("Please contact the Admin page"); // part three
                }
                i++;
                //while
                Console.WriteLine("============================");
                //do while
                int s = 0;
                do
                {
                    Console.WriteLine(s);
                }
                while (s > 2);
             
            }

        }
    }
}
