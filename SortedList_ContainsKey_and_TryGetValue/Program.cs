using System;
using System.Collections.Generic;
namespace SortedList_ContainsKey_and_TryGetValue
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

            if (!mark.ContainsKey(5))
                mark[5] = "HTC";
            string mar;
            if (mark.TryGetValue(5, out mar))
                Console.WriteLine("Key:{0}, value:{1}", 4, mar);

            Console.WriteLine('\n');

            SortedList<string, string> number = new SortedList<string, string>();
            number.Add("1", "One");
            number.Add("2", "Two");
            number.Add("3", null);
            number.Add("4", null);
            number.Add("5", "Five");

            if (!number.ContainsKey("6"))
                number["6"] = "Six";
            string num;
            if (number.TryGetValue("6", out num))
                Console.WriteLine("Key:{0}, Value:{1}", "6", num);
        }
    }
}
