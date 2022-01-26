namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            

                string noX = "";

                for (int i = 0; i < str.Length; i++)
                {
                    if ((str.Substring(i, 1) == "x") && (i != 0) && (i != str.Length - 1))
                    {
                        continue;
                    }

                    noX = noX + str.Substring(i, 1);

                }

                return noX;

            
        }

        
        
    }
}
