using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{

    [TestClass]
    public class Lucky13Test
    {
        //array of ints
        //true if the array contains no 1's and no 3's
        //bool GetLucky(int[] nums)


        [TestMethod]
        public void ArrayContainsNone()
        {
            //arrange
            Lucky13 sut = new Lucky13();

            //act
            int[] nums = new int[] { 0, 2, 4 };
            bool noThirteen = sut.GetLucky(nums);

            //assert
            Assert.IsTrue(noThirteen);
        }

        [TestMethod]
        public void OneReturnsFalse ()
        {
            //arrange
            Lucky13 sut = new Lucky13();

            //act
            int[] nums = new int[] { 1, 15, 99 };
            bool hasOne = sut.GetLucky(nums);

            //assert
            Assert.IsFalse(hasOne);
        }

        [TestMethod]
        public void ThreeReturnsFalse()
        {
            //arrange
            Lucky13 sut = new Lucky13();

            //act
            int[] nums = new int[] { 0, 3, 77 };
            bool hasThree = sut.GetLucky(nums);

            //assert
            Assert.IsFalse(hasThree);
        }

        [TestMethod]
        public void HasThirteen()
        {
            //arrange
            Lucky13 sut = new Lucky13();

            //act
            int[] nums = new int[] { 0, 2, 13 };
            bool hasThirteen = sut.GetLucky(nums);

            //assert
            Assert.IsTrue(hasThirteen);
        }

        [TestMethod]
        public void HasNegativeOne()
        {
            //arrange
            Lucky13 sut = new Lucky13();

            //act
            int[] nums = new int[] { -1, 2, 88 };
            bool hasNegativeOne = sut.GetLucky(nums);

            //assert
            Assert.IsTrue(hasNegativeOne);
        }

        [TestMethod]
        public void HasNegativeThree()
        {
            //arrange
            Lucky13 sut = new Lucky13();

            //act
            int[] nums = new int[] { 0, 2, -3 };
            bool hasNegativeThree = sut.GetLucky(nums);

            //assert
            Assert.IsTrue(hasNegativeThree);
        }

        [TestMethod]
        public void HasAllZeroes()
        {
            //arrange
            Lucky13 sut = new Lucky13();

            //act
            int[] nums = new int[] { 0, 0, 0 };
            bool hasZeroes = sut.GetLucky(nums);

            //assert
            Assert.IsTrue(hasZeroes);
        }

        [TestMethod]
        public void HasSingleInt()
        {
            //arrange
            Lucky13 sut = new Lucky13();

            //act
            int[] nums = new int[] { 13 };
            bool singleInt = sut.GetLucky(nums);

            //assert
            Assert.IsTrue(singleInt);
        }

    }
}
