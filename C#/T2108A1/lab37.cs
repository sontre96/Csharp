using System;

namespace T2108A1
{
    class lab37
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
            }
            else if (b >= c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}