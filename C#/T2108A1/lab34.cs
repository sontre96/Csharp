using System;

namespace T2108A1
{
    class lab34
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a >= b)
            {
                Console.WriteLine("a is greater than or equal to b");
            }
            else
            {
                Console.WriteLine("a is smaller than b");   
            }
        }
    }
}