using System;

namespace T2108A1
{
    class lab44
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int answer = 0;
            for (int i = a; i <= b; i++)
            {
                // answer += i means answer = answer + i
                answer += i;
            }
            Console.WriteLine(answer);
        }
    }
}