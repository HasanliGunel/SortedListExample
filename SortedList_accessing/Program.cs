using System;
using System.Collections.Generic;

namespace SortedList_accessing
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> mark = new SortedList<int, string>();

            mark.Add(4, "Samsung");
            mark.Add(2, "IPhone");
            mark.Add(1, "Huawei");
            mark.Add(3, "Xiaomi");
            Console.WriteLine(mark[1]);
            Console.WriteLine(mark[2]);
            Console.WriteLine(mark[3]);
            Console.WriteLine(mark[4]);

            Console.WriteLine('\n');
            mark[2] = "HTC";
            mark[5] = "Nokia";

            foreach (KeyValuePair<int, string> mar in mark)
                Console.WriteLine("Key:{0}, Value:{1}", mar.Key, mar.Value);

        }

    }
}
