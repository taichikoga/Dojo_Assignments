using System;

namespace fundamentals_i
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 1; i <=255; i++)
            // {
            //     Console.WriteLine(i);
            // }

            for (int j = 1; j <= 100; j++)
            {
                if (j%3 == 0 && j%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (j%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (j%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }

            int k = 1;
            while (k <= 100)
            {
                if (k%3 == 0 && k%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    k = k + 1;
                }
                else if (k%3 == 0)
                {
                    Console.WriteLine("Fizz");
                    k = k + 1;
                }
                else if (k%5 == 0)
                {
                    Console.WriteLine("Buzz");
                    k = k + 1;
                }
            }
        }
    }
}
