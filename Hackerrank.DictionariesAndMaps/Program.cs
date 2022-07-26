using System;
using System.Collections;

namespace Hackerrank.DictionariesAndMaps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = Console.Read();
            if (count >= 0 && count <= 100000)
            {
                var phoneBook = GetNameAndPhone(count);
                var queryNames = QueryNames(count, phoneBook);
                foreach (var queryName in queryNames)
                {
                    if (phoneBook[queryName] != null)
                        Console.WriteLine($"{queryName}={phoneBook[queryName]}");
                    else
                        Console.WriteLine("Not found");
                }
            }

            Console.WriteLine("Hello World!");
        }

        private static string[] QueryNames(int count, Hashtable phoneBook)
        {
            string[] queryNames = new string[count];
            for (int i = 0; i < count; i++)
            {
                queryNames[i] = Console.ReadLine();
            }
            return queryNames;
        }

        private static Hashtable GetNameAndPhone(int count)
        {
            Hashtable ret = new Hashtable();
            for(int i = 0; i < count; i++)
            {
                string namePhone = Console.ReadLine();
                ret[namePhone.Split(' ')[0]] = namePhone.Split(' ')[1];
            }
            return ret;
        }
    }
}
