namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of ints, return a new array length 2 containing the first and last elements from the
        original array. The original array will be length 1 or more.
        MakeEnds([1, 2, 3]) → [1, 3]
        MakeEnds([1, 2, 3, 4]) → [1, 4]
        MakeEnds([7, 4, 6, 2]) → [7, 2]
        */
        public int[] MakeEnds(int[] nums)
        {
            int[] firstLast = new int[2];

            firstLast[0] = nums[0];
            firstLast[firstLast.Length - 1] = nums[nums.Length - 1];


            return firstLast;
        }
    }
}
