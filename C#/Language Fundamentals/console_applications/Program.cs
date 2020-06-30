using System;

namespace console_applications
{
    class Program
    {
        static void Main(string[] args)
        {
            // int numRings = 5;
            // int numOfAllStarAppearances = 17;
            // if (numRings >= 5 || numOfAllStarAppearances > 3)
            // {
            // Console.WriteLine("Welcome, you are truly a legend");
            // }

            // // loop from 1 to 5 including 5
            // int start = 0;
            // int end = 5;
            // // loop from start to end including end
            // for (int i = start; i <= end; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // // loop from start to end excluding end
            // for (int i = start; i < end; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // int i = 1;
            // while (i <= 5)
            // {
            //     Console.WriteLine(i);
            //     i = i + 1;
            // }

            // Random rand = new Random();
            // for(int val = 0; val < 10; val++)
            // {
            //     //Prints the next random value between 2 and 8
            //     Console.WriteLine(rand.Next(0,100));
            // }

            // // Declaring an array of length 5, initialized by default to all zeroes
            // int[] numArray = new int[5];
            // // Declaring an array with pre-populated values
            // // For Arrays initialized this way, the length is determined by the size of the given data
            // int[] numArray2 = {1,2,3,4,6};

            // int[] arrayOfInts = {1, 2, 3, 4, 5};
            // Console.WriteLine(arrayOfInts[0]);    // The first number lives at index 0.
            // Console.WriteLine(arrayOfInts[1]);    // The second number lives at index 1.
            // Console.WriteLine(arrayOfInts[2]);    // The third number lives at index 2.
            // Console.WriteLine(arrayOfInts[3]);    // The fourth number lives at index 3.
            // Console.WriteLine(arrayOfInts[4]);    // The fifth and final number lives at index 4.

            // int[] arr = {1, 2, 3, 4};
            // Console.WriteLine($"The first number of the arr is {arr[0]}"); 
            // arr[0] = 8;
            // Console.WriteLine($"The first number of the arr is now {arr[0]}");
            // // The array has now changed!

            // string[] car_list = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"};
            // // The 'Length' property tells us how many values are in the Array (4 in our example here). 
            // // We can use this to determine where the loop ends: Length-1 is the index of the last value. 
            // for (int variable = 0; variable < car_list.Length; variable++)
            // {
            //     Console.WriteLine($"I own a {car_list[variable]}");
            // }

            string[] myCars = new string[] { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; 
            foreach (string car in myCars)
            {
                // We no longer need the index, because variable 'car' already represents each indexed value
                Console.WriteLine($"I own a {car}");
            }
        }
    }
}
