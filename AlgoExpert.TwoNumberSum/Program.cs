using System;

namespace AlgoExpert.TwoNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			int[] result = TwoNumberSum(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);

			Console.WriteLine(result[0]);
			Console.WriteLine(result[1]);
		}
		public static int[] TwoNumberSum(int[] array, int targetSum)
		{
			for (int i = 0; i < array.Length - 1; i++)
			{
				int first = array[i];
                for (int j = i +1; j < array.Length; j++)
				{
					int second = array[j];
					if (first + second == targetSum)
						return new int[] { first, second };
				}

			}

			return new int[0];
		}
	}
}
