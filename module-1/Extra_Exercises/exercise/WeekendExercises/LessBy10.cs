namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given three ints, a b c, return true if one of them is 10 or more less than one of the others.
        LessBy10(1, 7, 11) → true
        LessBy10(1, 7, 10) → false
        LessBy10(11, 1, 7) → true
        */
        public bool LessBy10(int a, int b, int c)
        {
            int[] testABC = new int[3] { a, b, c };

            for (int i = 0; i < 3; i++)
            {
                int j = i + 1;
                int k = i + 2;
                int l = i - 1;
                if (i > j  || i > k)
                {
                    return true;
                }
                else if (true)
                {

                }
            }


            return false;
        }
    }
}
