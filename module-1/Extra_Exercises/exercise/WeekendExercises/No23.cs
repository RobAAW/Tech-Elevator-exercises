namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given an int array length 2, return true if it does not contain a 2 or 3.
        No23([4, 5]) → true
        No23([4, 2]) → false
        No23([3, 5]) → false
        */
        public bool No23(int[] nums)
        {
            bool zeroTwo = nums[0] == 2 ? true : false;
            bool zeroThree = nums[0] == 3 ? true : false;
            bool oneTwo = nums[1] == 2 ? true : false;
            bool oneThree = nums[1] == 3 ? true : false;

            if ((zeroTwo == true || zeroThree == true) || (oneTwo == true || oneThree == true))
            {
                return false;
            }
            
            return true;
        }
    }
}
