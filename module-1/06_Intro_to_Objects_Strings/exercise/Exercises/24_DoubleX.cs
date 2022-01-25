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

            int firstX = str.IndexOf("x");


            for (int i = firstX; i < str.Length; i++)
            {
                if (str[i] == 'x' && str[i +1] == 'x')
                {
                    return true;
                }
            }  
            return false;
        }
    }
}
