namespace Exercises
{
    public partial class LogicalBranchingExercises
    {
        /*
	     The parameter weekday is true if it is a weekday, and the parameter vacation is true if we are on
	     vacation. We sleep in if it is not a weekday or we're on vacation. Return true if we sleep in.
	     SleepIn(false, false) → true
	     SleepIn(true, false) → false
	     SleepIn(false, true) → true
	     */
        public bool SleepIn(bool weekday, bool vacation)
        {
            //return true if sleep in
            //true if not a weekday || vacation
            if (!weekday || vacation )
            {
                return true;
            }
            return false;
        }
    }
}
