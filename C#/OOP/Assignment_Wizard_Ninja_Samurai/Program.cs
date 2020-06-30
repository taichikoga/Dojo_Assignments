using System;
using System.Collections.Generic;

namespace Assignment_Wizard_Ninja_Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime CurrentTime = DateTime.Now;
            System.Console.WriteLine("Hello");
            System.Console.WriteLine(CurrentTime);
            // Console.WriteLine("Hello World!");
            // Human Link = new Human("Link");
            // System.Console.WriteLine(Link.Name);

            // Human Ganon = new Human ("Ganon",10,10,10,500);
            // System.Console.WriteLine(Ganon.Name);
            // System.Console.WriteLine(Ganon.HealthProp);

            // Link.Attack(Ganon);
            // System.Console.WriteLine(Ganon.Name);
            // System.Console.WriteLine(Ganon.HealthProp);

            Wizard Mercy = new Wizard("Mercy");
            // System.Console.WriteLine(Mercy.Name);
            // System.Console.WriteLine(Mercy.Intelligence);
            // System.Console.WriteLine(Mercy.HealthProp);

            Ninja Genji = new Ninja("Genji");
            // System.Console.WriteLine(Genji.Name);
            // System.Console.WriteLine(Genji.Dexterity);

            Samurai Hanzo = new Samurai("Hanzo");
            // System.Console.WriteLine(Hanzo.Name);
            // System.Console.WriteLine(Hanzo.HealthProp);

            // Mercy.Attack(Hanzo);
            // System.Console.WriteLine(Hanzo.HealthProp);

            // Genji.Attack(Mercy);
            // System.Console.WriteLine(Mercy.HealthProp);

            // Hanzo.Attack(Genji);
            // System.Console.WriteLine(Genji.HealthProp);
            // Hanzo.Attack(Genji);
            // System.Console.WriteLine(Genji.HealthProp);
            // Hanzo.Attack(Genji);
            // System.Console.WriteLine(Genji.HealthProp);
            // Hanzo.Attack(Genji);
            // System.Console.WriteLine(Genji.HealthProp);
            // Hanzo.Attack(Genji);
            // System.Console.WriteLine(Genji.HealthProp);
            // Hanzo.Attack(Genji);
            // System.Console.WriteLine(Genji.HealthProp);

            // Mercy.Heal(Genji);
            // System.Console.WriteLine(Genji.HealthProp);

            // Hanzo.Meditate();
            // System.Console.WriteLine(Hanzo.HealthProp);

            // Genji.Steal(Mercy);
            // System.Console.WriteLine(Genji.HealthProp);
            // System.Console.WriteLine(Mercy.HealthProp);
        }
    }
}