using System;

namespace T2108A1
{
    class lab43
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= -n; i--)
            {
                Console.Write(i + " ");
            }
        }
    }
}