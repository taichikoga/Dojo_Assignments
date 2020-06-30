using System;
using System.Collections.Generic;

namespace Assignment_Wizard_Ninja_Samurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 175;
            HealthProp = 100;
        }

        public override int Attack(Human target)
        {
            Random rand = new Random();
            int blade = rand.Next(6);
            // System.Console.WriteLine(blade);
            if (blade == 0)
            {
                int blade_dmg = (Dexterity * 5) + 10;
                target.HealthProp -= blade_dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {blade_dmg} critical damage!");
                return target.HealthProp;
            }
            else
            {
                int dmg = Dexterity * 5;
                target.HealthProp -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.HealthProp;
            }
        }

        public int Steal(Human target)
        {
            int dmg = 5;
            target.HealthProp -= dmg;
            HealthProp += dmg;
            System.Console.WriteLine($"{Name} stole {dmg} hp from {target.Name}");
            return target.HealthProp;
        }
    }
}