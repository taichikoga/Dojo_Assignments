using System;

namespace Assignment_Human
{
    public class Human
    {
        // Fields for Humancopy
        public string Name;
        public int Strength = 3;
        public int Intelligence = 3;
        public int Dexterity = 3;
        internal int Health = 100;

        // add a public "getter" property to access health
        public int HealthProp
        {
            get
            {
                return Health;
            }
            set
            {
                Health = value;
            }
        }
        
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human() { }
        public Human(string name)
        {
            Name = name;
        }

        // Add a constructor to assign custom values to all fields
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

        // Build Attack method

        public int Attack(Human target)
        {
            if (target.HealthProp > 0)
            {
                target.HealthProp = target.HealthProp - (this.Strength*5);
            }
            return target.HealthProp;
        }
    }
}