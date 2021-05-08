using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = a + b;
            //Console.WriteLine("Answer is{0}", c);
            //Console.ReadLine();

            // 2:
            //  int a = Convert.ToInt32(Console.ReadLine());
            //  int b = a++;

            //   Console.WriteLine("Value of A{0}", a);
            //   Console.WriteLine("Value of B=a++{0}", b);
            //   b = ++a;
            //   Console.WriteLine("Value of A{0}", a);
            //   Console.WriteLine("Value of B=++a{0}", b);
            //3:
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            string s = a > b ? "A is bigger" : "B is Bigger";
            Console.WriteLine(s);



            Console.ReadLine();
        }
    }
}
