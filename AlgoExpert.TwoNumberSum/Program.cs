using System;

namespace AlgoExpert.TwoNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			int[] result = TwoNumberSum(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 13);

			Console.WriteLine(result[0]);
			Console.WriteLine(result[1]);
		}
		public static int[] TwoNumberSum(int[] array, int targetSum)
		{
			Array.Sort(array);
			int leftPosition = 0;
			int rightPosition = array.Length - 1;
			while (leftPosition < rightPosition)
            {
				int currentSum = array[leftPosition] + array[rightPosition];
				if (currentSum.Equals(targetSum))
					return new int[2] { array[leftPosition], array[rightPosition] };
				else if (currentSum < targetSum)
					leftPosition++;
				else
					rightPosition--;

            }

			return new int[0];
		}
	}
}
