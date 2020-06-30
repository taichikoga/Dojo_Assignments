using System;
using System.Collections.Generic;

namespace Assignment_Wizard_Ninja_Samurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 25;
            Dexterity = 3;
            HealthProp = 50;
        }

        //Provide an override Attack method to Wizard,
        //which reduces the target by 5 * Intelligence
        //and heals the Wizard by the amount of damage dealt
        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.HealthProp -= dmg;
            this.HealthProp += dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage and healed his/herself for {dmg}!");
            return target.HealthProp;
        }

        public int Heal(Human target)
        {
            if (target.Name == "Genji")
            {
                System.Console.WriteLine("You Need Healing! /s");
            }
            int healing = Intelligence * 5;
            target.HealthProp += healing;
            System.Console.WriteLine($"{Name} healed {target.Name} for {healing} hp!");
            return target.HealthProp;
        }
    }
}