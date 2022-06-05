using System;

namespace T2108A1
{
    class lab50
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            while (n1 <= 100)
            {
                if (n1 % 2 == 0)
                {
                    Console.Write(n1 + " ");
                }
                n1 += 1;
            }

            int n2 = int.Parse(Console.ReadLine());
            for (int i = n2; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}