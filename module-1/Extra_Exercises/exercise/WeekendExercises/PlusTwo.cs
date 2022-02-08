namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given 2 int arrays, each length 2, return a new array length 4 containing all their elements.
        PlusTwo([1, 2], [3, 4]) → [1, 2, 3, 4]
        PlusTwo([4, 4], [2, 2]) → [4, 4, 2, 2]
        PlusTwo([9, 2], [3, 4]) → [9, 2, 3, 4]
        */
        public int[] PlusTwo(int[] a, int[] b)
        {
            int[] allFour = new int[4];

            a.CopyTo(allFour, 0);
            b.CopyTo(allFour, 2);

            return allFour;
        }
    }
}
