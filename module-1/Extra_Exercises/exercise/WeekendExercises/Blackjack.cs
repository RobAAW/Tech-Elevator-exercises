namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given 2 int values greater than 0, return whichever value is nearest to 21 without going over. Return 0 if they both
        go over.
        Blackjack(19, 21) → 21
        Blackjack(21, 19) → 21
        Blackjack(19, 22) → 19
        */
        public int Blackjack(int a, int b)
        {
            int differenceA = 21 - a;
            int differenceB = 21 - b;

            bool below21A = a <= 21;
            bool below21B = b <= 21;

            if (!below21A && !below21B)
            {
                return 0;
            }
            else if (below21A && !below21B)
            {
                return a;
            }
            else if (below21B && !below21A)
            {
                return b;
            }
            else if (below21A && below21B && (differenceA < differenceB))
            {
                return a;
            }
            
            return b;
        }
    }
}
