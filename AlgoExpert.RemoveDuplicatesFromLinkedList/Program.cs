using System;
using System.Collections.Generic;

namespace AlgoExpert.RemoveDuplicatesFromLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList input = new LinkedList(1);
            addMany(input, new List<int> {
            1, 3, 4, 4, 4, 5, 6, 6
             });
            RemoveDuplicatesFromLinkedList(input);

            Console.WriteLine(input.value);
            
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

        public static LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
        {
            LinkedList current = linkedList;
            while (current != null)
            {
                var nextDistinct = current.next;
                while (nextDistinct != null && current.value == nextDistinct.value)
                    nextDistinct = nextDistinct.next;

                current.next = nextDistinct;
                current = nextDistinct;
            } 
            return linkedList;
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
