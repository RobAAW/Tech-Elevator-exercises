namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of ints, return the number of 9's in the array.
        ArrayCount9([1, 2, 9]) → 1
        ArrayCount9([1, 9, 9]) → 2
        ArrayCount9([1, 9, 9, 3, 9]) → 3
        */
        public int ArrayCount9(int[] nums)
        {

            int count = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 9)
                {
                    count += 1;
                }
            }


            return count;
        }
    }
}
