using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Classes
{
    class Cow : Animal 
    {
        public bool DoesHaveRider { get; set; }
        public int CountOfTimesMilked { get; set; }

        public Cow()
        {
            this.Greeting = "Moo";
            this.FavoriteFood = "Grass";
        }

        public int MilkMyCow()
        {
            this.CountOfTimesMilked = 3;
            return this.CountOfTimesMilked;
        }
    }
}
