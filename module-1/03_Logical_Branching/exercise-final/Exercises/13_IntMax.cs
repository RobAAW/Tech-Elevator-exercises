namespace Exercises
{
    public partial class LogicalBranchingExercises
    {
        /*
         Given three int values, a b c, return the largest.
         IntMax(1, 2, 3) → 3
         IntMax(1, 3, 2) → 3
         IntMax(3, 2, 1) → 3
         */
        public int IntMax(int a, int b, int c)
        {
            // if a > b then max is a otherwise its b
            int max = (a > b) ? a : b;

            // if max > c then max is still max, otherwise c is bigger
            max = (max > c) ? max : c;

            return max;
        }
    }
}
