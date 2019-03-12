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
                FavoriteFood = "Hay"
            };

            horse.Speak();
            horse.Eat();

            Console.WriteLine("Hello Frank!");

            Console.ReadLine();
        }
    }
}
