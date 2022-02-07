namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of ints, return true if one of the first 4 elements in the array is a 9. The array length may be less than 4.
        ArrayFront9([1, 2, 9, 3, 4]) → true
        ArrayFront9([1, 2, 3, 4, 9]) → false
        ArrayFront9([1, 2, 3, 4, 5]) → false
        */
        public bool ArrayFront9(int[] nums)
        {

            if (nums.Length < 4)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 9)
                    {
                        return true;
                    }
                }
            }
            else if (nums.Length >= 4)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (nums[i] == 9)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
