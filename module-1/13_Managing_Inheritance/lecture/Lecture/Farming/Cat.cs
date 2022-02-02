using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    class Cat : FarmAnimal
    {

        public Cat() : base ("Cat", "Meow")
        {

        }

        public sealed override string Sound
        {
            get 
            {
                return "Meow";
            }
        }

        public override string Eat()
        {
            return "ew, no that, I like the other can";
        }
    }
}
