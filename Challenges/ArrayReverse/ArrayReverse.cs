using System;

namespace Challenges.ArrayChallenges
{
	class ArrayReverse
	{
		public static void Reverse()
		{

			int[] arr = new int[] { 1, 2, 3, 4, 5 };

			for (int i = arr.Length - 1; i >= 0; i--)
			{
				Console.Write(arr[i]);
			}
			//Console.WriteLine();

			Console.WriteLine("This is array reverse called");
		}
	}
}