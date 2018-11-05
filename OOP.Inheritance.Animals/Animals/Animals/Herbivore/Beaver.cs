﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Herbivore
{
    class Beaver:Herbivore
    {
        public Beaver(bool canWalk, int legs, string fur, string name, int speed,int age)
                         : base(canWalk,legs,fur,name, speed,age)
        {
            CanWalk = canWalk;
            Legs = legs;
            Fur = fur;
        }

        public new  string Eat()
        {
            return "Potatoes";
        }
    }
}
