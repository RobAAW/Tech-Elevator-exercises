namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an array of ints of even length, return a new array length 2 containing the middle two elements from
        the original array. The original array will be length 2 or more.
        MakeMiddle([1, 2, 3, 4]) → [2, 3]
        MakeMiddle([7, 1, 2, 3, 4, 9]) → [2, 3]
        MakeMiddle([1, 2]) → [1, 2]
        */
        public int[] MakeMiddle(int[] nums)
        {
            int[] middleElements = new int[2];

            int arrayOne = nums.Length / 2 - 1;
            int arrayTwo = nums.Length / 2;

            middleElements[0] = nums[arrayOne];
            middleElements[1] = nums[arrayTwo];



            return middleElements;
        }
    }
}
