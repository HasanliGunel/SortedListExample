using System;
using System.Collections.Generic;

namespace SortedList_add
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> SL = new SortedList<string, string>();
            SL.Add("1", "One");
            SL.Add("2", "Two");
            SL.Add("3", null);
            SL.Add("4", null);
            SL.Add("5", "Five");

            Console.WriteLine("----Ilkin Key-value----");
            foreach (KeyValuePair<string, string> sl in SL)
                Console.WriteLine("Key:{0}, Value:{1}", sl.Key, sl.Value);

            Console.WriteLine('\n');

            SL.Add("6", "Six");
            SL.Add("7", "Seven");

            Console.WriteLine("----Yeni Key-value elave etdikden sonra");

            foreach (var sl in SL)
                Console.WriteLine("Key:{0}, Value:{1}", sl.Key, sl.Value);

            Console.WriteLine('\n');

            SortedList<int, string> mark = new SortedList<int, string>()
            {
                {1,"Samsung" },
                {2,"IPhone" },
                {3,"Huawei" },
                {4, "Xiaomi" },
            };

            Console.WriteLine("Evvel");

            foreach (var mar in mark)
                Console.WriteLine("Key:{0}, Value:{1}", mar.Key, mar.Value);

            Console.WriteLine('\n');

            mark.Add(5, "LG");
            mark.Add(6, "Casper");
            Console.WriteLine("Sonra");
            foreach (var mar in mark) 
                Console.WriteLine("Key:{0}, Value:{1}", mar.Key, mar.Value);
        }
    }
}
