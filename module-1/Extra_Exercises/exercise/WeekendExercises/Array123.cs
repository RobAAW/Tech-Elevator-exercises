namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of ints, return true if .. 1, 2, 3, .. appears in the array somewhere.
        Array123([1, 1, 2, 3, 1]) → true
        Array123([1, 1, 2, 4, 1]) → false
        Array123([1, 1, 2, 1, 2, 3]) → true
        */
        public bool Array123(int[] nums)
        {

            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i-1] == 1 && nums[i] == 2 && nums[i+1] == 3)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
