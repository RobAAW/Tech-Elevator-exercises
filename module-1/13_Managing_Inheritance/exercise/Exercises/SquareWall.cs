using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class SquareWall : RectangleWall
    {

        public SquareWall (string name, string color, int sidelength) : base(name, color, sidelength, sidelength)
        {

        }

        public override string ToString()
        {
            return Name + " " + "(" + Length + "x" + Length + ")" + " square";
        }

    }

    
}
