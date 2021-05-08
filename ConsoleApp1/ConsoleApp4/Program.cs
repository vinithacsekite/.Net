using System;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
        int car_speed = Convert.ToInt32(Console.ReadLine());
        int speed_limit = Convert.ToInt32(Console.ReadLine());
        if (car_speed > speed_limit) {
                Console.WriteLine("Speed Limit Exceeded");
                int extra = speed_limit - car_speed;
                if ((extra * 5) > 12)
                {
                    Console.WriteLine("No License");
                }
            }
            else
            {
                Console.WriteLine("Correct speed");
            }
            Console.ReadLine();
        }
        
        }
    
    }
