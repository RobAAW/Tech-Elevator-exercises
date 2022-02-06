using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Test
    {
        //true if non-negative number is 1 or 2 less than a multiple of 20
        //bool IsLessThanMultipleOf20(int n)


        [TestMethod]
        public void IsMultipleOf20()
        {
            //arrange
            Less20 sut = new Less20();

            //act
            bool multiple20 = sut.IsLessThanMultipleOf20(40);

            //assert
            Assert.IsFalse(multiple20);

        }

        [TestMethod]
        public void IsNotMultipleOf20_OneLess()
        {
            //arrange
            Less20 sut = new Less20();

            //act
            bool NotMultiple20 = sut.IsLessThanMultipleOf20(29);

            //assert
            Assert.IsFalse(NotMultiple20);

        }

        [TestMethod]
        public void IsNotMultipleOf20_TwoLess()
        {
            //arrange
            Less20 sut = new Less20();

            //act
            bool NotMultiple20Two = sut.IsLessThanMultipleOf20(28);

            //assert
            Assert.IsFalse(NotMultiple20Two);

        }

        [TestMethod]
        public void IntIsZero()
        {
            //arrange
            Less20 sut = new Less20();

            //act
            bool zeroInt = sut.IsLessThanMultipleOf20(0);

            //assert
            Assert.IsFalse(zeroInt);

        }

        [TestMethod]
        public void IsMultipleOf20_OneLess()
        {
            //arrange
            Less20 sut = new Less20();

            //act
            bool MultipleOfTwenty_OneLess = sut.IsLessThanMultipleOf20(59);

            //assert
            Assert.IsTrue(MultipleOfTwenty_OneLess);

        }

        [TestMethod]
        public void IsMultipleOf20_TwoLess()
        {
            //arrange
            Less20 sut = new Less20();

            //act
            bool MultipleOfTwenty_TwoLess = sut.IsLessThanMultipleOf20(98);

            //assert
            Assert.IsTrue(MultipleOfTwenty_TwoLess);

        }

        [TestMethod]
        public void LargeMultiple_TwoLess()
        {
            //arrange
            Less20 sut = new Less20();

            //act
            bool largeMultiple = sut.IsLessThanMultipleOf20(2147483638);

            //assert
            Assert.IsTrue(largeMultiple);

        }
    }
}
