using System;
using System.Collections.Generic;

namespace SortedList_example
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

            Console.WriteLine("Reqemler");

            foreach (var num in SL)
                Console.WriteLine("Key:{0}, Value:{1}", num.Key, num.Value);
            Console.WriteLine('\n');

            SortedList<int, string> mark = new SortedList<int, string>()
            {
                {4,"Samsung" },
                {2,"IPhone" },
                {1,"Huawei" },
                {3, "Xiaomi" },
            };

            Console.WriteLine("Markalar");

            foreach (var mar in mark)
                Console.WriteLine("Key:{0}, Value:{1}", mar.Key, mar.Value);
        }
    }
}
