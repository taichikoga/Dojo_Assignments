using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> some_list = new List<object>();

            int num0 = 7;
            int num1 = 28;
            int num2 = -1;
            string char3 = "chair";

            some_list.Add(num0);
            some_list.Add(num1);
            some_list.Add(num2);
            some_list.Add(char3);

            foreach (var some_value in some_list)
            {
                Console.WriteLine(some_value);
            }
            Console.WriteLine(some_list.Count);

            int sum = 0;
            for (int i = 0; i < some_list.Count; i++)
            {
                if (some_list[i] is int)
                {
                    Console.WriteLine(some_list[i]);
                    int this_num = (int)some_list[i];
                    sum = sum + this_num;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
