﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
        DoubleX("axxbb") → true
        DoubleX("axaxax") → false
        DoubleX("xxxxx") → true
        */
        public bool DoubleX(string str)
        {


            int index = str.IndexOf("x");

            return (index >= 0 && index == str.IndexOf("xx", index));

        }
    }
}
