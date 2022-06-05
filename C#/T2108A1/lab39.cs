using System;

namespace T2108A1
{
    class lab39
    {
        static void Main(string[] args)
        {
            int score1 = int.Parse(Console.ReadLine());
            if (score1 < 0 || score1 > 10)
            {
                Console.WriteLine("The score is not valid");
            }
            else
            {
                Console.WriteLine("The score is valid");
            }

            int score2 = int.Parse(Console.ReadLine());
            if (score2 >= 0 && score2 <= 10)
            {
                Console.WriteLine("The score is valid");
            }
            else
            {
                Console.WriteLine("The score is not valid");
            }
        }
    }
}