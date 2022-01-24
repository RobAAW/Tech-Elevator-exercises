namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed.
        The "yak" strings will not overlap.
        StringYak("yakpak") → "pak"
        StringYak("pakyak") → "pak"
        StringYak("yak123ya") → "123ya"
        */
        public string StringYak(string str)
        {

            string noYak = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[1] == 'y' && str[i + 1] == 'a' && str[i + 2] == 'k')
                {
                    noYak = str.Remove(i, 3);
                }
            }
                return noYak;
      
        }
    }
}
