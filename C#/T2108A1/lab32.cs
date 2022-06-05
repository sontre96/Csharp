using System;

namespace T2108A1
{
    class lab32
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("n is an even number");
            }
            if (n % 2 != 0)
            {
                Console.WriteLine("n is an odd number");
            }

            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("a is an even number");
            }
            else
            {
                Console.WriteLine("a is an odd number");
            }
        }
    }
}