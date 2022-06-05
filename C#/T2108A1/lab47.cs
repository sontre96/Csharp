using System;

namespace T2108A1
{
    class lab47
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int answer = 1;
            for (int i = 1; i <= n; i++)
            {
                // answer *= i means answer = answer * i;
                answer *= i;
            }
            Console.Write(answer);
        }
    }
}