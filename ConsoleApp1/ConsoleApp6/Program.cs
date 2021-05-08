using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Table Number and End point");
            int start = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i*start <= end; i++)
            {
                Console.WriteLine("\n{0} * {1} = {2}", i, start, i * start);
            }
            int a = Convert.ToInt32(Console.ReadLine());
            int brk = Convert.ToInt32(Console.ReadLine());
            for ( int i = 1; i < a; i++)
            {
                if (i == brk)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
