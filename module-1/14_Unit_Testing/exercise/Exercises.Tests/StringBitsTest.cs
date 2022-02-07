using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        //return a new string made of every other char starting with the first
        //string GetBits(string str)


        [TestMethod]
        public void StringNullOrEmpty_ReturnNull()
        {
            //arrange
            StringBits sut = new StringBits();

            //act
            string nullString = sut.GetBits(null);

            //assert
            Assert.AreEqual("", nullString);
        }

        [TestMethod]
        public void ReturnEveryOther()
        {
            //arrange
            StringBits sut = new StringBits();

            //act
            string everyOther = sut.GetBits("Hello");

            //assert
            Assert.AreEqual("Hlo", everyOther);
        }

        [TestMethod]
        public void StringOneCharacter()
        {
            //arrange
            StringBits sut = new StringBits();

            //act
            string oneChar = sut.GetBits("H");

            //assert
            Assert.AreEqual("H", oneChar);
        }

        [TestMethod]
        public void StringOfNumbers()
        {
            //arrange
            StringBits sut = new StringBits();

            //act
            string numString = sut.GetBits("2,147,483,647");

            //assert
            Assert.AreEqual("2174367", numString);
        }

        [TestMethod]
        public void NonAlpha()
        {
            //arrange
            StringBits sut = new StringBits();

            //act
            string nonAlphabet = sut.GetBits(",,,,,");

            //assert
            Assert.AreEqual(",,,", nonAlphabet);
        }

        [TestMethod]
        public void StringOfNumbersCommaDelimited()
        {
            //arrange
            StringBits sut = new StringBits();

            //act
            string commaNums = sut.GetBits("2,147,483,647");

            //assert
            Assert.AreNotEqual("2,174,367", commaNums);
        }
    }
}
