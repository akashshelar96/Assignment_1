using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Positive_Negative_Zero
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Enter number is positive ");
            }
            else if (num < 0)
            {
                Console.WriteLine("Enter number is nagative ");
            }
            else
            {
                Console.WriteLine("Enter number is zero ");
            }

            Console.ReadLine();
        }
    }
}
