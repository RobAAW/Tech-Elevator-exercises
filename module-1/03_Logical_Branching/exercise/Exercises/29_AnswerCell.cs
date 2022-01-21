namespace Exercises
{
    public partial class LogicalBranchingExercises
    {
        /*
         Your cell phone rings. Return true if you should answer it. Normally you answer, except in the morning
         you only answer if it is your mom calling. In all cases, if you are asleep, you do not answer.
         AnswerCell(false, false, false) → true
         AnswerCell(false, false, true) → false
         AnswerCell(true, false, false) → false
         */
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            //true if cell rings
            //only answer am if mom calls
            //if asleep do not answer

            if (isAsleep)
            {
                return false;
            }
            else if (isMorning)
            {
                if (isMom)
                {
                    return true;
                }
                return false;
            }
            if (!isMorning)
            {
                return true;
            }
            return true;
        }
    }
}
