using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {

            int x = 14;
            int z = 5;
            int y = 1;

            int result1 = x+= (y - (x++ * z));
            Console.WriteLine($"You first result is:{result1}");

            int result2 = z = (--x - y * 5);
            Console.WriteLine($"You second result is:{result2}");

            int result3 = x/= x + (5 % z);
            Console.WriteLine($"You third result is:{result3}");

            int result4 = z = ( x++ + (y * 5));
            Console.WriteLine($"You fourth result is:{result4}");

            int result5 = x = y - (x++ * z);
            Console.WriteLine($"You fifth result is:{result5}");

        }
    }
}
