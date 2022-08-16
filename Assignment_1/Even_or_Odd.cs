using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Even_or_Odd
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine(i+ "Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write(i + "Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
