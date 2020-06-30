using System;
using System.Collections.Generic;

namespace Assignment_Wizard_Ninja_Samurai
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        
        public int HealthProp
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
        
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        
        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            System.Console.WriteLine(target.health);
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
    }
}