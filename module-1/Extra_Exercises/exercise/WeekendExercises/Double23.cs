namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an int array, return true if the array contains 2 twice, or 3 twice. The array will be length 0, 1, or 2.
        Double23([2, 2]) → true
        Double23([3, 3]) → true
        Double23([2, 3]) → false
        */
        public bool Double23(int[] nums)
        {
            if (nums.Length == 2)
            {
                if (nums[0] == 3 && nums[1] == 3)
                {
                    return true;
                }
                else if (nums[0]== 2 && nums[1] == 2)
                {
                    return true;
                }
                return false;
            }
            else
            return false;
        }

    }
}
