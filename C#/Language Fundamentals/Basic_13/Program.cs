using System;
using System.Collections.Generic;

namespace Basic_13
{
    class Program
    {
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int banana = 0; banana <= 255; banana++)
            {
                Console.WriteLine(banana);
            }
        }

        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int orange = 1; orange <= 255; orange++)
            {
                if (orange%2 != 0)
                {
                    Console.WriteLine(orange);
                }
            }
        }

        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            
            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3

            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum = sum + i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
            foreach (int apple in numbers)
            {
                Console.WriteLine(apple);
            }
        }

        public static int FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.

            int max = numbers[0];
            for (int mouse = 1; mouse < numbers.Length; mouse++)
            {
                if (numbers[mouse] > max)
                {
                    max = numbers[mouse];
                }
            }
            Console.WriteLine(max);
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.

            int sum = 0;
            for (int wind = 0; wind < numbers.Length; wind++)
            {
                sum = sum + numbers[wind];
            }
            int avg = sum / numbers.Length;
            Console.WriteLine(avg);
        }

        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].

            int count = 0;
            for (int cup = 0; cup <= 255; cup++)
            {
                if (cup%2 != 0)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine(count);

            int[] array = new int [count];

            array[0] = 1;
            for (int i = 1; i < 128; i++)
            {
            array[i] = array[i - 1] + 2;
            Console.WriteLine(array[i]);
            }
            return array;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).

            int count = 0;
            for (int phone = 0; phone < numbers.Length; phone++)
            {
                if (numbers[phone] > y)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine(count);
            return count;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]

            for (int cable = 0; cable < numbers.Length; cable++)
            {
                numbers[cable] = numbers[cable]*numbers[cable];
            }
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].

            for (int table = 0; table < numbers.Length; table++)
            {
                if (numbers[table] < 0)
                {
                    numbers[table] = 0;
                }
            }
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.

            int max = numbers[0];
            int min = numbers[0];
            int sum = numbers[0];
            for (int clipper = 1; clipper < numbers.Length; clipper++)
            {
                if (max < numbers[clipper])
                {
                    max = numbers[clipper];
                }
                if (min > numbers[clipper])
                {
                    min = numbers[clipper];
                }
                sum = sum + numbers[clipper];
            }
            int avg = sum/numbers.Length;
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(avg);
        }

        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].

            for (int trophy = 0; trophy < numbers.Length; trophy++)
            {
                if (trophy < numbers.Length - 1)
                {
                    numbers[trophy] = numbers[trophy + 1];
                }
                else if (trophy == numbers.Length - 1)
                {
                    numbers[numbers.Length - 1] = 0;
                }
            }
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
        }

        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].

            object[] new_array = new object [numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    new_array[i] = numbers[i];
                }
                else
                {
                    string dojo = "Dojo";
                    new_array[i] = dojo;
                }
            }

            foreach (object value in new_array)
            {
                Console.WriteLine(value);
            }
            return new_array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(new int[] {1,2,3,4,5});
            // FindMax(new int[] {-3, -5, -7});
            // GetAverage(new int[] {2, 10, 3});
            // OddArray();
            // GreaterThanY(new int[] {1, 3, 5, 7}, 3);
            // SquareArrayValues(new int[] {1,5,10,-10});
            // EliminateNegatives(new int[] {1, 5, 10, -2});
            // MinMaxAverage(new int[] {1, 5, 10, -2});
            // ShiftValues(new int[] {1, 5, 10, 7, -2});
            NumToString(new int[] {-1, -3, 2});
        }
    }
}
