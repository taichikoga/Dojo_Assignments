using System;
using System.Collections.Generic;

namespace Assignment_Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Buffet menu1 = new Buffet();
            // Console.WriteLine(menu1.Menu[0].Name);
            // Console.WriteLine(menu1.Menu.Count);
            // Console.WriteLine(menu1.Serve().Name);

            Ninja ninja1 = new Ninja();
            // Console.WriteLine(ninja1.isFull);
            ninja1.Eat(menu1.Serve());
            ninja1.Eat(menu1.Serve());
            ninja1.Eat(menu1.Serve());
            ninja1.Eat(menu1.Serve());
            ninja1.Eat(menu1.Serve());
            ninja1.Eat(menu1.Serve());
            ninja1.Eat(menu1.Serve());
            ninja1.Eat(menu1.Serve());
            ninja1.Eat(menu1.Serve());
            ninja1.Eat(menu1.Serve());
            ninja1.Eat(menu1.Serve());
            ninja1.Eat(menu1.Serve());
            ninja1.Eat(menu1.Serve());
            ninja1.Eat(menu1.Serve());
        }
    }
}
