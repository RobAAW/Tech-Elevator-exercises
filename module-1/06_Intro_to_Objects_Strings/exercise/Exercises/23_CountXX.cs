﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Count the number of "xx" in the given string. Overlapping is allowed, so "xxx" contains 2 "xx".
        CountXX("abcxx") → 1
        CountXX("xxx") → 2
        CountXX("xxxx") → 3
        */
        public int CountXX(string str)
        {

            int totalX = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str.Contains("xxxx"))
                {
                    totalX += 3;
                }
                if (str.Contains("xxx"))
                {
                    totalX += 2;
                }
                if (str.Contains("xxxx"))
                {
                    totalX += 3;
                }
            }
            return totalX;
        }
    }
}
