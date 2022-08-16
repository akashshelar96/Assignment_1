using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Div_5_or_11
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Please Enter your the number:");
            n = int.Parse(Console.ReadLine());
            if (n % 5 == 0 && n % 11 == 0)
            {
                Console.WriteLine("Your number is divisible by 5 and 11");

            }
            else
            {
                Console.WriteLine("Your number is not divissible by 5 and 11");
                Console.ReadLine();
            }
        }
    }
}
