using Inheritance.Classes;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var horse = new Animal {
                Name = "Clippity Clop",
                FavoriteFood = "Hay",
                Greeting = "Hello, Wilbur."
            };

            horse.Speak();
            horse.Eat();

            Console.ReadLine();
        }
    }
}
