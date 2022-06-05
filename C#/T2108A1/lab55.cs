using System;

namespace T2108A1
{
	class lab55
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 2 == 0)
				{
					continue;
				}
				Console.Write(i + " ");
			}
		}
	}
}