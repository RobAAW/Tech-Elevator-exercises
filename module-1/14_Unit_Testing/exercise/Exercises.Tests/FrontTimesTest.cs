using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        //string and a non-negative int n
        //front of the string is the first 3 chars
        //or whatever is there if the string is less than length 3
        //Return n copies of the front


        [TestMethod]
        public void IsStringNullOrEmpty()
        {
            //arrange
            FrontTimes sut = new FrontTimes();

            //act
            string nullEmpty = sut.GenerateString(null, 3);

            //assert
            Assert.AreEqual("", nullEmpty);
        }

        [TestMethod]
        public void StringMoreThanThree()
        {
            //arrange
            FrontTimes sut = new FrontTimes();

            //act
            string firstTwo = sut.GenerateString("Chocolate", 2);

            //assert
            Assert.AreEqual("ChoCho",firstTwo);
        }

        [TestMethod]
        public void IntOfZero()
        {
            //arrange
            FrontTimes sut = new FrontTimes();

            //act
            string zeroInt = sut.GenerateString("Chocolate", 0);

            //assert
            Assert.AreEqual("", zeroInt);
        }

        [TestMethod]
        public void StringLessThanThree()
        {
            //arrange
            FrontTimes sut = new FrontTimes();

            //act
            string techElevator = sut.GenerateString("Te", 3);

            //assert
            Assert.AreEqual("TeTeTe", techElevator);
        }

        [TestMethod]
        public void OneLetterString()
        {
            //arrange
            FrontTimes sut = new FrontTimes();

            //act
            string oneLetter = sut.GenerateString("C", 7);

            //assert
            Assert.AreEqual("CCCCCCC", oneLetter);
        }

    }
}
