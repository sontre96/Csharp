using System;

namespace T2108A1
{
	class lab66
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			int[,] arr = new int[n, m];
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					arr[i, j] = int.Parse(Console.ReadLine());
				}
			}

			int answer = 0;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					answer += arr[i, j];
				}
			}
			Console.WriteLine(answer);
		}
	}
}