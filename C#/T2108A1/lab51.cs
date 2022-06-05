using System;

namespace T2108A1
{
    class lab51
    {
        static void Main(string[] args)
        {
			int n1 = int.Parse(Console.ReadLine());
			int i1 = 1;
			int answer1 = 0;
			while (i1 <= n1)
			{
				if (n1 % i1 == 0)
				{
					answer1++;
				}
				i1++;
			}
			Console.Write(answer1);

			int n2 = int.Parse(Console.ReadLine());
			int answer2 = 0;
			for (int i2 = 1; i2 <= n2; i2++)
			{
				if (n2 % i2 == 0)
				{
					answer2++;
				}
			}
			Console.Write(answer2);
		}
    }
}