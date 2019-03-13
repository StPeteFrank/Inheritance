using Inheritance.Classes;
using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var horse = new Horse {
                Name = "Clippity Clop"
            };

            horse.Speak();
            horse.Eat();

            var cow = new Cow
            {
                Name = "Betsy"
             };

            cow.Speak();
            cow.Eat();

            Console.ReadLine();
        }
    }
}
