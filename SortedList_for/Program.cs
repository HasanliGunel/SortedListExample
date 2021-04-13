using System;
using System.Collections.Generic;

namespace SortedList_for
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> mark = new SortedList<int, string>()
            {
                {1,"Samsung" },
                {2,"IPhone" },
                {3,"Huawei" },
                {4, "Xiaomi" },
            };
            //Console.WriteLine(mark.Count);
            for (int i = 0; i < mark.Count; i++)
                Console.WriteLine("Key:{0}, Value:{1}", mark.Keys[i], mark.Values[i]);
        }
    }
}
