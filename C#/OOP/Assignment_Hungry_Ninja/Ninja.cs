using System;
using System.Collections.Generic;

namespace Assignment_Hungry_Ninja
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        // add a constructor
        public Ninja()
        {
            FoodHistory = new List<Food>();
            calorieIntake = 0;
        }
        
        // add a public "getter" property called "IsFull"
        public bool isFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        // build out the Eat method
        public void Eat(Food item)
        {
            // bool isFull1 = this.isFull;
            if (isFull == true)
            {
                Console.WriteLine("This ninja is already full");
            }
            else if (isFull == false)
            {
                Console.WriteLine("This ninja is still hungry");

                Console.WriteLine(this.calorieIntake);
                this.calorieIntake += item.Calories;
                Console.WriteLine(this.calorieIntake);

                // Console.WriteLine(item);
                FoodHistory.Add(item);
                Console.WriteLine(item.Name);
                if (item != null)
                {
                    if (item.IsSpicy == true)
                    {
                        Console.WriteLine("This is spicy");
                    }
                    else
                    {
                        Console.WriteLine("This is not spicy");
                    }
                }
                if (item != null)
                {
                    if (item.IsSweet == true)
                    {
                        Console.WriteLine("This is sweet");
                    }
                    else
                    {
                        Console.WriteLine("This is not sweet");
                    }
                }

                foreach (dynamic food in FoodHistory)
                {
                    Console.WriteLine(food.Name);
                }
            }
        }
    }
}