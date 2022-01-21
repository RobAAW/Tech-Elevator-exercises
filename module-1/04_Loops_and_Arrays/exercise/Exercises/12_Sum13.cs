namespace Exercises
{
    public partial class Exercises
    {
        /*
         Return the sum of the numbers in the array, returning 0 for an empty array. Except the number
         13 is very unlucky, so it does not count and numbers that come immediately after a 13 also do
         not count.
         Sum13([1, 2, 2, 1]) → 6
         Sum13([1, 1]) → 2
         Sum13([1, 2, 2, 1, 13]) → 6
         Sum13([1, 2, 2, 1, 13, 3]) → 6
         Sum13([1, 2, 2, 1, 13, 3, 4]) → 10
         */
        public int Sum13(int[] nums)
        {
            //13 and following do not count
            //return zero for empty

            if (nums.Length == 0)
            {
                return 0;
            }
            // need a running sum total

            int sum = 0; 

            if (nums[0] != 13)
            {
                sum += nums[i];
            }
            // add next value unless 13
            //anything 1 index after 13 does not count
            //inspect/look at each element of nums

            for (int i = 0; i < nums.Length -1; i++)
            {
                if (i > 0 && nums[i] != 13 && nums[i - 1] != 13)
                {
                    sum += nums[i];
                }
            }
            //if it is 13 ignore
            //if not true add next value to the running total
            //add the next value to it
            //increment the counter




            return sum;
        }
    }
}
