using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 Basic Arrays:

            // int[] array1 = {0,1,2,3,4,5,6,7,8,9};
            // for (int banana = 0; banana < array1.Length; banana++)
            // {
            //     Console.WriteLine(array1[banana]);
            // }

            // string[] array2 = {"Tim", "Martin", "Nikki", "Sara"};
            // // foreach list iteration
            // foreach (string apple in array2)
            // {
            //     Console.WriteLine(apple);
            // }
            // // or for loop list iteration
            // for (int apple = 0; apple < array2.Length; apple++)
            // {
            //     Console.WriteLine(array2[apple]);
            // }

            // or
            // List<string> array2 = new List<string>();
            // array2.Add("Tim");
            // array2.Add("Martin");
            // array2.Add("Nikki");
            // array2.Add("Sara");

            // foreach (string name in array2)
            // {
            //     Console.WriteLine(name);
            // }

            // bool[] array3 = new bool[10];
            // for (int orange = 0; orange < array3.Length; orange++)
            // {
            //     if (orange == 0)
            //     {
            //         array3[orange] = true;
            //     }
            //     else if (array3[orange - 1] == true)
            //     {
            //         array3[orange] = false;
            //     }
            //     else if (array3[orange - 1] == false)
            //     {
            //         array3[orange] = true;
            //     }
            // }
            // foreach (bool something in array3)
            // {
            //     Console.WriteLine(something);
            // }

            // List of Flavors:

            // List<string> treats = new List<string>();

            // treats.Add("Chocolate");
            // treats.Add("Vanilla");
            // treats.Add("Strawberry");
            // treats.Add("Rainbow");
            // treats.Add("Coffee");

            // foreach (string flavor in treats)
            // {
            //     Console.WriteLine(flavor);
            // }

            // Console.WriteLine(treats.Count);

            // Console.WriteLine(treats[2]);
            // treats.RemoveAt(2);
            // Console.WriteLine(treats.Count);

            // User Info Dictionary:

            // Dictionary<string,string> matches = new Dictionary<string,string>();
            // matches.Add("Tim", "Chocolate");
            // matches.Add("Martin", "Vanilla");
            // matches.Add("Nikki", "Rainbow");
            // matches.Add("Sara", "Coffee");

            // foreach (KeyValuePair<string,string> entry in matches)
            // {
            //     Console.WriteLine(entry.Key + " - " + entry.Value);
            // }
            // // or
            // foreach (var entry in matches)
            // {
            //     Console.WriteLine(entry.Key + " - " + entry.Value);
            // }
        }
    }
}
