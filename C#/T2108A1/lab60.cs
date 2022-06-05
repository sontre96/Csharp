using System;

namespace T2108A1
{
	class lab60
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] arr = new int[n];

			for (int i = 0; i < n; i++)
			{
				arr[i] = int.Parse(Console.ReadLine());
			}

			Console.Write(arr[0] + arr[n - 1]);
		}
	}
}