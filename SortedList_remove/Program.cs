using System;
using System.Collections.Generic;

namespace SortedList_remove
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> mark = new SortedList<int, string>()
            {
                {5,"HTC" },
                {2,"IPhone" },
                {1,"Samsung" },
                {4, "Xiaomi" },
                {3,"Huawei" }

            };
            mark.Remove(1);
            mark.Remove(10);
            mark.RemoveAt(0);

            
            foreach (KeyValuePair<int, string> mar in mark)
                Console.WriteLine("Key:{0}, Value:{1}", mar.Key, mar.Value);
        }
    }
}
