using System;

namespace Assignment_Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human human1 = new Human("Link", 2, 2, 2, 100);
            Human human2 = new Human("Ganon", 10, 10, 10, 500);
            Console.WriteLine(human1.Name);
            Console.WriteLine(human1.Strength);
            Console.WriteLine(human1.Intelligence);
            Console.WriteLine(human1.Dexterity);
            Console.WriteLine(human1.Health);
            Console.WriteLine(human2.Name);
            Console.WriteLine(human2.Strength);
            Console.WriteLine(human2.Intelligence);
            Console.WriteLine(human2.Dexterity);
            Console.WriteLine(human2.Health);
            human1.Attack(human2);
            Console.WriteLine(human2.Name);
            Console.WriteLine(human2.Health);
            human1.Attack(human2);
            Console.WriteLine(human2.Name);
            Console.WriteLine(human2.Health);
        }
    }
}
