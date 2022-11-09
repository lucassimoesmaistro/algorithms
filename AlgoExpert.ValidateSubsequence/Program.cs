using System;
using System.Collections.Generic;

namespace AlgoExpert.ValidateSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var retorno1 = IsValidSubsequence(new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 22, 25, 6 });
            Console.WriteLine("Hello World!");

        }
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int iSequence = 0;

            foreach (var item in array)
            {
                if (item != sequence[iSequence])
                {
                    if (sequence.Contains(item))
                        return false;
                }
                else
                {
                    if (sequence.Count.Equals(iSequence + 1))
                        return true;
                    else
                        iSequence++;
                }
            }
            return sequence.Count.Equals(iSequence+1);
        }
    }
}
