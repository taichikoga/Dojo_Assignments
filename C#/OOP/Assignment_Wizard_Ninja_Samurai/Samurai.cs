using System;
using System.Collections.Generic;

namespace Assignment_Wizard_Ninja_Samurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            HealthProp = 200;
        }

        public override int Attack(Human target)
        {
            base.Attack(target);
            if (target.HealthProp < 50)
            {
                int temp = target.HealthProp;
                target.HealthProp = 0;
                Console.WriteLine($"{Name} finished off {target.Name} by dealing additional {temp} damage!");
            }
            return target.HealthProp;
        }

        public int Meditate()
        {
            if (HealthProp < 200)
            {
                HealthProp = 200;
                System.Console.WriteLine($"{Name} meditated and healed himself to full health!");
            }
            else{
                System.Console.WriteLine($"{Name} is already at full health!");
            }
            return HealthProp;
        }
    }
}