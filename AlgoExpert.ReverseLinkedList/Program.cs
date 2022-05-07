using System;
using System.Collections.Generic;

namespace AlgoExpert.ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList input = new LinkedList(1);
            addMany(input, new List<int> {
            2, 3, 4, 5
             });
            ReverseLinkedList(input);
        }
        public static LinkedList ReverseLinkedList(LinkedList linkedList)
        {
            var current = linkedList;
            var head = linkedList;
            var next = current.Next;
            current.Next = null;
            while (next != null)
            {
                head = next;
                next = head.Next;
                head.Next = current;
                current = head;
            }
            return head;
        }

        public class LinkedList
        {
            public int Value;
            public LinkedList Next = null;

            public LinkedList(int value)
            {
                this.Value = value;
            }
        }

        public static LinkedList addMany(LinkedList ll, List<int> values)
        {
            Program.LinkedList current = ll;
            while (current.Next != null)
            {
                current = current.Next;
            }
            foreach (var value in values)
            {
                current.Next = new LinkedList(value);
                current = current.Next;
            }
            return ll;
        }
    }
}
