using System;

namespace AlgoExpert.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = new int[10] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
            int target = 72;
            int result = BinarySearch(array, target);
            Console.WriteLine(result);
        }

        public static int BinarySearch(int[] array, int target)
        {
            return BinarySearch(array, target, 0, array.Length - 1);
        }

        public static int BinarySearch(int[] array, int target, int left, int right)
        {
            if (left > right)
                return -1;
            int middle = (int)((left + right) / 2);
            if (array[middle] == target)
                return middle;
            else if (array[middle] > target)
                return BinarySearch(array, target, left, middle - 1);
            else
                return BinarySearch(array, target, middle + 1, right);
        }
    }
}
