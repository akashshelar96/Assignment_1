using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Div_by_5
    {
        static void Main(string[] args)
        {
            int num;


            Console.WriteLine("Enter the number:");
            num = int.Parse(Console.ReadLine());
            // checking if the number is divisible by 3 and 5
            if (num % 5 == 0)
            {
                Console.WriteLine("Divisible by 5");
            }
            else
            {
                Console.WriteLine("Not divisible by 5");
            }
            Console.ReadLine();
        }
    }
}
