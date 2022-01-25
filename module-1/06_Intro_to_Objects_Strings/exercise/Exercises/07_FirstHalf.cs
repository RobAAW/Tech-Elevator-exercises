namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string of even length, return the first half. So the string "WooHoo" yields "Woo".
        FirstHalf("WooHoo") → "Woo"
        FirstHalf("HelloThere") → "Hello"
        FirstHalf("abcdef") → "abc"
        */
        public string FirstHalf(string str)
        {
            int half = 0;

            half = str.Length / 2;

            return str.Substring(0, half);

            //return null;
        }
    }
}
