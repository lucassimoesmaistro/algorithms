using System;

namespace AlgoExpert.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = new int[4] { 1, 5, 23, 111 };
            int target = 5;
            int result = BinarySearch(array, target);
            Console.WriteLine(result);
        }

        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int rigth = array.Length - 1;
            while (left != rigth)
            {
                int middle = (int)((left + rigth) / 2);
                if (array[middle] == target)
                {
                    left = middle;
                    break;
                }
                if (array[middle] > target)
                    rigth = middle - 1;
                else
                    left = middle + 1;
            }

            return array[left] == target ? left : -1;
        }
    }
}
