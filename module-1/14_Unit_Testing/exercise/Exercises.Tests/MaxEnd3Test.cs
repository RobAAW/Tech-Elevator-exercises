using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {
        //array of ints length 3
        //figure out which is larger between the first and last elements
        //set all the other elements to be that value
        //Return the changed array
        //int[] MakeArray(int[] nums)


        [TestMethod]
        public void CheckFirstAndLast()
        {
            //arrange
            MaxEnd3 sut = new MaxEnd3();

            //act
            int[] returned = { 3, 3, 3 };
            int[] givenNums = sut.MakeArray(new int[] { 1, 2, 3 });
            

            //assert
            CollectionAssert.AreEqual(returned, givenNums);
        }

        [TestMethod]
        public void FirstIsLarger()
        {
            //arrange
            MaxEnd3 sut = new MaxEnd3();

            //act
            int[] returned = { 10, 10, 10 };
            int[] givenNums = sut.MakeArray(new int[] { 10, 2, 3 });


            //assert
            CollectionAssert.AreEqual(returned, givenNums);
        }

        [TestMethod]
        public void LastIsLarger()
        {
            //arrange
            MaxEnd3 sut = new MaxEnd3();

            //act
            int[] returned = { 11, 11, 11 };
            int[] givenNums = sut.MakeArray(new int[] { 9, 10, 11 });


            //assert
            CollectionAssert.AreEqual(returned, givenNums);
        }

        [TestMethod]
        public void BothAreEqual()
        {
            //arrange
            MaxEnd3 sut = new MaxEnd3();

            //act
            int[] returned = { 3, 3, 3 };
            int[] givenNums = sut.MakeArray(new int[] { 3, 2, 3 });


            //assert
            CollectionAssert.AreEqual(returned, givenNums);
        }

        [TestMethod]
        public void AllZeroes()
        {
            //arrange
            MaxEnd3 sut = new MaxEnd3();

            //act
            int[] returned = { 0, 0, 0 };
            int[] givenNums = sut.MakeArray(new int[] { 0, 0, 0 });


            //assert
            CollectionAssert.AreEqual(returned, givenNums);
        }

        [TestMethod]
        public void IntIsNegative()
        {
            //arrange
            MaxEnd3 sut = new MaxEnd3();

            //act
            int[] returned = { 1, 1, 1 };
            int[] givenNums = sut.MakeArray(new int[] { -100, 2, 1 });


            //assert
            CollectionAssert.AreEqual(returned, givenNums);
        }

        [TestMethod]
        public void LargestNegative()
        {
            //arrange
            MaxEnd3 sut = new MaxEnd3();

            //act
            int[] returned = { -100, -100, -100 };
            int[] givenNums = sut.MakeArray(new int[] { -100, 2, -300 });


            //assert
            CollectionAssert.AreEqual(returned, givenNums);
        }

        [TestMethod]
        public void ZeroAndNegative()
        {
            //arrange
            MaxEnd3 sut = new MaxEnd3();

            //act
            int[] returned = { 0, 0, 0 };
            int[] givenNums = sut.MakeArray(new int[] { -1, 2, 0 });


            //assert
            CollectionAssert.AreEqual(returned, givenNums);
        }
    }
}
