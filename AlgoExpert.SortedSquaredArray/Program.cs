using System;

namespace AlgoExpert.SortedSquaredArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7] { 1, 2, 3, 5, 6, 8, 9 };
            var output = SortedSquaredArray(array);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] SortedSquaredArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * array[i];
            }
            Array.Sort(array);
            return array;
        }
    }
}
