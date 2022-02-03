namespace Exercises
{
    public partial class Exercises
    {
        /*
        Start with 2 int arrays, a and b, each length 2. Consider the sum of the values in each array. Return the
        array which has the largest sum. In event of a tie, return a.
        BiggerTwo([1, 2], [3, 4]) → [3, 4]
        BiggerTwo([3, 4], [1, 2]) → [3, 4]
        BiggerTwo([1, 1], [1, 2]) → [1, 2]
        */
        public int[] BiggerTwo(int[] a, int[] b)
        {
            int sumA = 0;
            int sumB = 0;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] += sumA;
            }
            for (int i = 0; i < b.Length; i++)
            {
                b[i] += sumB;
            }
            if (sumA == sumB)
            {
                return new int[] {a[0], a[1]};
            }
            else if (sumB > sumA)
            {
                return new int[] { b[0], b[1] };
            }
            else
            return new int[] { a[0], a[1] };
        }
    }
}
