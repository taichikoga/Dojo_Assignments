﻿using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing an empty list of Motorcycle Manufacturers
            List<string> bikes = new List<string>();

            //Use the Add function in a similar fashion to push
            bikes.Add("Kawasaki");
            bikes.Add("Triumph");
            bikes.Add("BMW");
            bikes.Add("Moto Guzzi");
            bikes.Add("Harley Davidson");
            bikes.Add("Suzuki");

            //Accessing a generic list value is the same as you would an array
            Console.WriteLine(bikes[2]); //Prints "BMW"
            Console.WriteLine($"We currently know of {bikes.Count} motorcycle manufacturers.");

            //Using our array of motorcycle manufacturers from before
            //we can easily loop through the list of them with a C-style for loop
            //this time, however, Count is the attribute for a number of items.
            Console.WriteLine("The current manufacturers we have seen are:");
            for (var idx = 0; idx < bikes.Count; idx++)
            {
                Console.WriteLine("-" + bikes[idx]);
            }

            // Insert a new item between a specific index
            bikes.Insert(2, "Yamaha");

            Console.WriteLine("The current manufacturers we have seen are:");
            for (var idx = 0; idx < bikes.Count; idx++)
            {
                Console.WriteLine("-" + bikes[idx]);
            }

            //Removal from Generic List
            //Remove is a lot like Javascript array pop, but searches for a specified value
            //In this case we are removing all manufacturers located in Japan
            bikes.Remove("Suzuki");
            bikes.Remove("Yamaha");
            bikes.RemoveAt(0); //RemoveAt has no return value however. removes value at index of 0

            //The updated list can then be iterated through using a foreach loop
            Console.WriteLine("List of Non-Japanese Manufacturers:");
            foreach (string manu in bikes)
            {
                Console.WriteLine("-" + manu);
            }
        }
    }
}
