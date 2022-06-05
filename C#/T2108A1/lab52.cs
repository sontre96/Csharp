using System;

namespace T2108A1
{
	class lab52
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int answer1 = 1;
			while (b > 0)
			{
				answer1 *= a;
				b--;
			}
			Console.Write(answer1);

			int c = int.Parse(Console.ReadLine());
			int d = int.Parse(Console.ReadLine());
			int answer2 = 1;
			for (; d > 0; d--)
			{
				answer2 *= c;
			}
			Console.Write(answer2);
		}
	}
}