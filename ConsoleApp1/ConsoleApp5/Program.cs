using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2021 - 1990 ;
            int s = 1990;
            int inc = 0;
            s += 5;
            while (s < 2021)
            {
                s += 5;
                inc += 1;

            }
            Console.WriteLine(inc);
            Console.WriteLine(year / 5);
            Console.ReadLine();
        }
    }
}
