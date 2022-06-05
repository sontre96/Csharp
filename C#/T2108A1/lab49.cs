using System;

namespace T2108A1
{
    class lab49
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(i * 5 + j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}