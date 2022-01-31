namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }
        public HomeworkAssignment (int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;

        }
        
        //derived property - not stored, it's calculated/evaluated
        public string LetterGrade 
        {
            get
            {
                double gradePercentage = (double)EarnedMarks / PossibleMarks;
                if (gradePercentage >= .9)
                {
                    return "A";
                }
                else if (gradePercentage >= .8)
                {
                    return "B";
                }
                else if (gradePercentage >= .7)
                {
                    return "C";
                }
                else if (gradePercentage >= .6)
                {
                    return "D";
                }
                else 
                {
                    return "F";      
                }


            }


        }   

        
    }
}
