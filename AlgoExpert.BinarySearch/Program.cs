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
        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double result =  (meal_cost + (meal_cost * ((double)(tip_percent)) / 100) + (meal_cost * (((double)(tax_percent)) / 100)));
            Console.WriteLine(Math.Round((Double)result, 0));
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
