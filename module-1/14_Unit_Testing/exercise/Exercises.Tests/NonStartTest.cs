using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        //Given 2 strings, return their concatenation
        //omit the first char of each
        //will be at least length 1.
        //string GetPartialString(string a, string b)

        [TestMethod]
        public void AIsNull()
        {
            //arrange
            NonStart sut = new NonStart();

            //act
            string aNull = sut.GetPartialString(null, "There");

            //assert
            Assert.AreEqual("here", aNull);
        }

        [TestMethod]
        public void BIsNull()
        {
            //arrange
            NonStart sut = new NonStart();

            //act
            string bNull = sut.GetPartialString("Here", null);

            //assert
            Assert.AreEqual("ere", bNull);
        }

        [TestMethod]
        public void OneLengthStrings()
        {
            //arrange
            NonStart sut = new NonStart();

            //act
            string oneLength = sut.GetPartialString("a", "b");

            //assert
            Assert.AreEqual("", oneLength);
        }

        [TestMethod]
        public void StringIsNumber()
        {
            //arrange
            NonStart sut = new NonStart();

            //act
            string numString = sut.GetPartialString("13", "There");

            //assert
            Assert.AreEqual("3here", numString);
        }



    }
}
