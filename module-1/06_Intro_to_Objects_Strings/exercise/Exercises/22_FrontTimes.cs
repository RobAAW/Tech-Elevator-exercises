namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or
        whatever is there if the string is less than length 3. Return n copies of the front;
        FrontTimes("Chocolate", 2) → "ChoCho"
        FrontTimes("Chocolate", 3) → "ChoChoCho"
        FrontTimes("Abc", 3) → "AbcAbcAbc"
        */
        public string FrontTimes(string str, int n)
        {

            string resultString = "";
            string strToCopy = str;
            
            
            if (strToCopy.Length > 3)
            {
                strToCopy = strToCopy.Substring(0, 3);
            }

            for (int i = 0; i < n; i++)
            {
                resultString += strToCopy;
            }

            return resultString;



            /*string copies = "";

            if (str.Length <= 3)
            {
                return str + str + str;
            }


            
            string threeChars = str.Substring(0, 3);
            

            for (int i = 0; i < n; i++)
            {
                copies += threeChars;
            }

            return copies;
  */
        }

    }
}
