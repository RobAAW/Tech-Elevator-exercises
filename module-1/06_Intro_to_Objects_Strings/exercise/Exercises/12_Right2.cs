namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start.
        The string length will be at least 2.
        Right2("Hello") → "loHel"
        Right2("java") → "vaja"
        Right2("Hi") → "Hi"
        */
        public string Right2(string str)
        {

            if (str.Length <= 2)
            {
                return str;
            }

            string noLast2 = str.Substring(str.Length - 2);
            string rotate2Right = str.Substring(0, str.Length - 2);
            return noLast2 + rotate2Right;

            //return null;
        }
    }
}
