using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 600;
            int c = 40;

            int res = a > b ? (a > c ? a : c) : (b > c ? b : c);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
