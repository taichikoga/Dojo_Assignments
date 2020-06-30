using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datatype nameofvariable = assigned value
            int x = 5;
            List<int> numbers = new List<int>() {1,2,3,4};
            numbers.Add(x);

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
