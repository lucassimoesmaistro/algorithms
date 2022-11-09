using System;
using System.Collections;
using System.Collections.Generic;

namespace Hackerrank.DictionariesAndMaps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int64 count = Convert.ToInt64(Console.ReadLine());
            Hashtable phoneBook = new Hashtable();
            if (count >= 0 && count <= 100000)
                phoneBook = GetNameAndPhone(count);
            var queryNames = QueryNames(count);
            foreach (var queryName in queryNames)
            {
                if (phoneBook[queryName] != null)
                    Console.WriteLine($"{queryName}={phoneBook[queryName]}");
                else
                    Console.WriteLine("Not found");
            }

            Console.WriteLine("Hello World!");
        }

        private static List<string> QueryNames(Int64 count)
        {
            string name;
            List<string> queryNames = new List<string>();
            while ((name = Console.ReadLine()) != null)
                queryNames.Add(name);
            return queryNames;
        }

        private static Hashtable GetNameAndPhone(Int64 count)
        {
            Hashtable ret = new Hashtable();
            Int64 i = 0;
            do
            {
                string namePhone = Console.ReadLine();
                ret[namePhone.Split(' ')[0]] = namePhone.Split(' ')[1];
                i++;
            } while (i < count);
            return ret;
        }
    }
}
