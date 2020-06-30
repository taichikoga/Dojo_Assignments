using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {

        public static int[] RandomArray()
        {
            int[] array = new int [10];
            Random rand = new Random();
            for (int value = 0; value < array.Length; value++)
            {
                array[value] = rand.Next(5,26);
            }

            int max = array[0];
            int min = array[0];
            int sum = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
                if (min > array[i])
                {
                    min = array[i];
                }
                sum = sum + array[i];
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);

            foreach (int val in array)
            {
                Console.WriteLine(val);
            }
            return array;
        }

        public static string TossCoin()
        {
            // Console.WriteLine("Toss a Coin!");
            Random rand = new Random();
            int result = rand.Next(2);
            if (result == 0)
            {
                Console.WriteLine("Heads");
                return "Heads";
            }
            else if (result == 1)
            {
                Console.WriteLine("Tails");
                return "Tails";
            }
            return "Toss a Coin!";
        }

        public static double TossMultipleCoins(int num)
        {
            // TossCoin();
            double heads_count = 0;
            for (int val = 1; val <= num; val++)
            {
                if (TossCoin() == "Heads")
                {
                    heads_count = heads_count + 1;
                }
            }
            double heads_ratio = heads_count / num;
            Console.WriteLine(heads_ratio);
            return heads_ratio;
        }

        public static void Names ()
        {
            List<string> new_names = new List<string>();
            new_names.Add("Todd");
            new_names.Add("Tiffany");
            new_names.Add("Charlie");
            new_names.Add("Geneva");
            new_names.Add("Sydney");

            foreach (string val in new_names)
            {
                Console.WriteLine(val);
            }
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // RandomArray();
            // TossCoin();
            // TossMultipleCoins(5);
            Names();
        }
    }
}
