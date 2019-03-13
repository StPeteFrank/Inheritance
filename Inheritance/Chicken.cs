using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Classes
{
    class Chicken : Animal
    {
        public bool DoesHaveRider { get; set; }
        public int CountOfEggBatchesGiven { get; set; }

        public Chicken()
        {
            this.Greeting = "Cluck";
            this.FavoriteFood = "Corn";
        }
        public int GivenMeEggs()
        {
            this.CountOfEggBatchesGiven = 6;
            return this.CountOfEggBatchesGiven;

        }
    }
}
