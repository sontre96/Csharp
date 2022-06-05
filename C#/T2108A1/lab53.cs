using System;

namespace T2108A1
{
	class lab53
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			while (a <= b)
			{
				if (a % 3 == 0 && a % 5 == 0)
				{
					Console.Write(a + " ");
				}
				a++;
			}

			int c = int.Parse(Console.ReadLine());
			int d = int.Parse(Console.ReadLine());
			for (int i = c; i <= d; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					Console.Write(i + " ");
				}
			}
		}
	}
}