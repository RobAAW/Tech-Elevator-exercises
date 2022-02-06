using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        //array of ints
        //return true if the array is length 1 or more
        //and the first element and the last element are equal.
        //bool IsItTheSame(int[] nums)

        [TestMethod]
        public void LengthIsLessThanOne()
        {
            //arrange
            SameFirstLast sut = new SameFirstLast();

            //act
            int[] nums = new int[] {};
            bool hasNone = sut.IsItTheSame(nums);


            //assert
            Assert.IsFalse(hasNone);
        }

        [TestMethod]
        public void FirstLastEqual()
        {
            //arrange
            SameFirstLast sut = new SameFirstLast();

            //act
            int[] nums = new int[] {1, 2, 1 };
            bool firstLast = sut.IsItTheSame(nums);


            //assert
            Assert.IsTrue(firstLast);
        }

        [TestMethod]
        public void KindaButNegative()
        {
            //arrange
            SameFirstLast sut = new SameFirstLast();

            //act
            int[] nums = new int[] {-1, 2, 1 };
            bool aNegative = sut.IsItTheSame(nums);


            //assert
            Assert.IsFalse(aNegative);
        }

        [TestMethod]
        public void EdgeCase()
        {
            //arrange
            SameFirstLast sut = new SameFirstLast();

            //act
            int[] nums = new int[] { 2147483647, 1, 2147483647 };
            bool edgeCase = sut.IsItTheSame(nums);


            //assert
            Assert.IsTrue(edgeCase);
        }

        [TestMethod]
        public void EdgeCaseTwo()
        {
            //arrange
            SameFirstLast sut = new SameFirstLast();

            //act
            int[] nums = new int[] { -2147483647, 1, -2147483647 };
            bool edgeCaseTwo = sut.IsItTheSame(nums);


            //assert
            Assert.IsTrue(edgeCaseTwo);
        }

        [TestMethod]
        public void EqualZeroes()
        {
            //arrange
            SameFirstLast sut = new SameFirstLast();

            //act
            int[] nums = new int[] { 0, 2147483647, 0 };
            bool bothZeroes = sut.IsItTheSame(nums);


            //assert
            Assert.IsTrue(bothZeroes);
        }


    }
}
