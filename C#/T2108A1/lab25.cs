using System;

namespace T2108A1
{
    class lab25
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a % b = " + (a - b * (a / b)));
        }
    }
}