using System;
using System.Collections.Generic;

namespace MergeLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList headOne = new LinkedList(2);
            addMany(headOne, new List<int> {
            6,7,8
             });
            LinkedList headTwo = new LinkedList(1);
            addMany(headTwo, new List<int> {
            3,4,5,9,10
             });
            LinkedList result = mergeLinkedLists(headOne, headTwo);

            Console.WriteLine(result.value);
        }

        public static LinkedList mergeLinkedLists(LinkedList headOne, LinkedList headTwo)
        {
            LinkedList p1 = headOne;
            LinkedList p2 = headTwo;
            LinkedList prev = null;
            while (p1 != null && p2 != null)
            {
                if (p1.value > p2.value)
                {
                    if (prev != null)
                        prev.next = p2;
                    prev = p2;
                    p2 = p2.next;
                    prev.next = p1;
                }
                else
                {
                    prev = p1;
                    p1 = p1.next;
                }

            }
            if (p1 == null)
                prev.next = p2;
            return headOne.value > headTwo.value ? headTwo : headOne;
        }
        public static LinkedList addMany(LinkedList ll, List<int> values)
        {
            Program.LinkedList current = ll;
            while (current.next != null)
            {
                current = current.next;
            }
            foreach (var value in values)
            {
                current.next = new LinkedList(value);
                current = current.next;
            }
            return ll;
        }


        public class LinkedList
        {
            public int value;
            public LinkedList next;

            public LinkedList(int value)
            {
                this.value = value;
                this.next = null;
            }

        }
    }
}
