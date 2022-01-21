namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        10. What code do we need to write so that we can find the highest
             number in the array randomNumbers?
             TOPIC: Looping Through Arrays
        */
        public int FindTheHighestNumber(int[] randomNumbers)
        {
            //create a placeholder
            //iterate  over array
            //check each element
            //if value of element is greater than plaeholder
            //assign that value to placeholder
            int greatestNumber = randomNumbers[0];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                if (randomNumbers[i] > greatestNumber)
                {
                    greatestNumber = randomNumbers[i];
                }
            }
            return greatestNumber;
        }
    }
}
