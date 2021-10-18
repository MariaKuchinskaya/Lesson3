using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            const double pi = 3.141;

            Console.WriteLine("Insert the number:");

            int r = Convert.ToInt32(Console.ReadLine());

            int i = Convert.ToInt32(Console.ReadLine());

            var square = pi * r*(r + i);

            Console.Write($"Your result is: {square}"); 

        }
    }
}


