namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string of even length, return a string made of the middle two chars, so the string "string"
        yields "ri". The string length will be at least 2.
        MiddleTwo("string") → "ri"
        MiddleTwo("code") → "od"
        MiddleTwo("Practice") → "ct"
        */
        public string MiddleTwo(string str)
        {

            int size = str.Length/2;

            if (str.Length <= 2)
            {
                return str;
            }
            return str.Substring(size - 1, 2);  
        }
    }
}
