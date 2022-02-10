namespace Exercises
{
    public partial class LogicalBranchingExercises
    {
        /*
         Return true if the given non-negative number is a multiple of 3 or 5, but not both.
         (Hint: Think "mod".)
         Old35(3) → true
         Old35(10) → true
         Old35(15) → false
         */
        public bool Old35(int n)
        {
            bool multipleOf3 = (n % 3 == 0);
            bool multipleOf5 = (n % 5 == 0);

            return multipleOf3 ^ multipleOf5;
        }
    }
}
