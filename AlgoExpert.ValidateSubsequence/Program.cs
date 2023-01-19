using System;
using System.Collections.Generic;

namespace AlgoExpert.ValidateSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var retorno1 = IsValidSubsequence(new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 1, 22, 23, 6, -1, 8, 10 });
            Console.WriteLine("Hello World!");

        }
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int position = 0;
            bool isSubsequence = false;
            foreach (var item in sequence)
            {
                if (position >= array.Count)
                {
                    isSubsequence = false;
                    break;
                }
                for (int i = position; i < array.Count; i++)
                {

                    if (item == array[i])
                    {
                        isSubsequence = true;
                        position = i + 1;
                        break;
                    }

                }
                if (!isSubsequence)
                    break;
            }
            return isSubsequence;
        }
    }
}
