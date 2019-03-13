using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Classes
{
    public abstract class Animal      //Abstract base class for Animals with properties and methods. It will prevent anyone form instanciating that class anywhere in the program.
    {
        public string Greeting { get; set; }
        public string Name { get; set; }
        public string FavoriteFood { get; set; }

        public void Speak()
        {
            Console.WriteLine($"{this.Greeting}");
        }

        public void Eat()
        {
            Console.WriteLine($"My name is {Name} and my favorite food is {FavoriteFood}");
        }


    }
}
