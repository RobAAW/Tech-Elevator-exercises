using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTest
    {

        //"you" is the stylishness of your clothes, in the range 0..10
        //"date" is the stylishness of your date's clothes
        //getting the table 0=no, 1=maybe, 2=yes
        //very stylish, 8 or more, then the result is 2
        //exception if either has style of 2 or less, result is 0
        //Otherwise the result is 1
        //GetATable(int you, int date)


        [TestMethod]
        public void DatingAboveMyLevel()
        {
            //arrange
            DateFashion sut = new DateFashion();

            //act
            int meSlob = sut.GetATable(2, 10);

            //assert
            Assert.AreEqual(0, meSlob);

        }

        [TestMethod]
        public void IsntSheLovely()
        {
            //arrange
            DateFashion sut = new DateFashion();

            //act
            int loveHerMind = sut.GetATable(10, 3);

            //assert
            Assert.AreEqual(2, loveHerMind);

        }

        [TestMethod]
        public void TensInOurEyes()
        {
            //arrange
            DateFashion sut = new DateFashion();

            //act
            int midwest10 = sut.GetATable(5, 5);

            //assert
            Assert.AreEqual(1, midwest10);

        }

        [TestMethod]
        public void ShesAYinzerImWorkingOnMyself()
        {
            //arrange
            DateFashion sut = new DateFashion();

            //act
            int pierogiLover = sut.GetATable(7, 3);

            //assert
            Assert.AreEqual(1, pierogiLover);

        }

        [TestMethod]
        public void NightAtEatNPark()
        {
            //arrange
            DateFashion sut = new DateFashion();

            //act
            int justStayHome = sut.GetATable(2, 3);

            //assert
            Assert.AreEqual(0, justStayHome);

        }
    }
}
