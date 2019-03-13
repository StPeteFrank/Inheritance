using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Classes
{
    class Horse : Animal
    {
        public bool DoesHaveRider { get; set; }
        public int CountOfHorseShoes { get; set; }

        public Horse()
        {
            this.Greeting = "Neigh";
            this.FavoriteFood = "Hay";
        }

        public int ShoeMyHorse()
        {
            this.CountOfHorseShoes = 4;
            return this.CountOfHorseShoes;
        }
    }
}
