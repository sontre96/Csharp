using System;

namespace T2108A1
{
    class lab38
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 10 && a <= 100)
            {
                Console.WriteLine(a + " is in the range [10, 100]");
            }
            else
            {
                Console.WriteLine(a + " is not in the range [10, 100]");
            }
        }
    }
}