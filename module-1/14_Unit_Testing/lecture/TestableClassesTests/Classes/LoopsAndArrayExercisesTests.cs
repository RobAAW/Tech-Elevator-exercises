using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class LoopsAndArrayExercisesTests
    {
        //CollectionAssert
        //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
        //.AllItemsAreUnique() - Checks for uniqueness among actual collection
        //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
        //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
        //.AreNotEqual() - Opposite of AreEqual
        //.AreNotEquilavent() - Opposite or AreEqualivent
        //.Contains() - Checks to see if collection contains a value/object

        [TestMethod]
        public void MiddleWayTest()
        {
            //Arrange
            LoopsAndArrayExercises sut = new LoopsAndArrayExercises();
            int[] a = { 1, 2, 3 };
            int[] b = new int[3];
            b[0] = 4;
            b[1] = 5;
            b[2] = 6;

            //Act
            //expected
            int[] expected = { 2, 5 };

            //actual
            int[] actual = sut.MiddleWay(a, b);


            //Assert
            CollectionAssert.AreEqual(expected, actual);

        }

        /*middleWay([1, 2, 3], [4, 5, 6]) → [2, 5]
        middleWay([7, 7, 7], [3, 8, 0]) → [7, 8]
        middleWay([5, 2, 9], [1, 4, 5]) → [2, 4]
        */
        //public int[] MiddleWay(int[] a, int[] b)


    }
}