﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of ints, swap the first and last elements in the array. Return the modified array. The array
        length will be at least 1.
        SwapEnds([1, 2, 3, 4]) → [4, 2, 3, 1]
        SwapEnds([1, 2, 3]) → [3, 2, 1]
        SwapEnds([8, 6, 7, 9, 5]) → [5, 6, 7, 9, 8]
        */
        public int[] SwapEnds(int[] nums)
        {
            int[] swapIt = new int[] { };

            nums.CopyTo(swapIt, 0);

            if (nums.Length == 1)
            {
                return swapIt;
            }
            else
            
            swapIt[0] = nums[nums.Length - 1];
            swapIt[swapIt.Length - 1] = nums[0];


            return swapIt;
        }
    }
}