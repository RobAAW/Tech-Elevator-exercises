namespace Exercises
{
    public partial class LogicalBranchingExercises
    {
        /*
         We have a loud talking parrot. The "hour" parameter is the current hour time in the range 0..23.
         We are in trouble if the parrot is talking and the hour is before 7 or after 20. Return true if
         we are in trouble.
         ParrotTrouble(true, 6) → true
         ParrotTrouble(true, 7) → false
         ParrotTrouble(false, 6) → false
         */
        public bool ParrotTrouble(bool talking, int hour)
        {
            //true if in trouble
            //trouble before 7 and after 20
            if (talking && (hour < 7 || hour > 20))
            {
                return true;
            }
            else 

            return false;
        }
    }
}
