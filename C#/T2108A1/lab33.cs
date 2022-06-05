using System;

namespace T2108A1
{
    class lab33
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("a is equal to 0");
            }
            if (a < 0)
            {
                Console.WriteLine("a is a negative number");
            }
            if (a > 0)
            {
                Console.WriteLine("a is a positive number");
            }

            int b = int.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("b is equal to 0");
            }
            else
            {
                if (b < 0)
                {
                    Console.WriteLine("b is a negative number");
                }
                else
                {
                    Console.WriteLine("b is a positive number");
                }
            }

            int c = int.Parse(Console.ReadLine());
            if (c == 0)
            {
                Console.WriteLine("c is equal to 0");
            }
            else if (c < 0)
            {
                Console.WriteLine("c is a negative number");
            }
            else
            {
                Console.WriteLine("c is a positive number");
            }
        }
    }
}