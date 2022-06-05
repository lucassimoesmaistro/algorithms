using System;
using System.Linq;

namespace AlgoExpert.ArrayOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4] { 5, 1, 4, 2 };
            var output = ArrayOfProducts(array);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

        }

        public static int[] ArrayOfProducts(int[] array)
        {
            int[] output = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int product = 1;
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j)
                        product *= array[j];
                }
                output[i] = product;
            }
            return output;
        }
    }
}
