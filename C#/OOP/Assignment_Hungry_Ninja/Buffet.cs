using System;
using System.Collections.Generic;

namespace Assignment_Hungry_Ninja
{
    public class Buffet
    {
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Apple", 100, false, true),
                new Food("Banana", 100, false, false),
                new Food("Orange", 100, false, true),
                new Food("Grape", 100, false, true),
                new Food("Watermelon", 100, false, true),
                new Food("Pepper", 100, true, false),
                new Food("Bread", 100, false, false)
            };
        }
        
        public Food Serve()
        {
            Random rand = new Random();
            rand.Next(Menu.Count + 1);
            return Menu[rand.Next(Menu.Count)];
        }
    }
}