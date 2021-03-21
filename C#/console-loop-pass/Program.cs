using System;

namespace console_loop_pass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x=0;
            do
            {
                string name;
                name = Console.ReadLine();
                if (name == "sinan")
                {
                    Console.WriteLine("welcome");
                    break ;
                }
                else
                { 
                    Console.WriteLine("Try again"); x++; 
                }
            } 
            while (x <= 3);
           
        }
    }
}
