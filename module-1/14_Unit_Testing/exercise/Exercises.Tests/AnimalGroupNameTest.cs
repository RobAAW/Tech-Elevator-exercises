using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{

    [TestClass]
    public class AnimalGroupNameTest
    {
        //if animal is in dict, return herd name
        [TestMethod]
        /*public void meaningful_name()
        {

        }*/
        public void AnimalNameInDict_ReturnHerdName()
        {
            //arrange
            AnimalGroupName sut = new AnimalGroupName();

            //act
            string herdName = sut.GetHerd("giraffe");

            //assert
            Assert.AreEqual("Tower", herdName);

        }
        //animal name case insensitive
        [TestMethod]
        public void AnimalNameInDict_CaseInsensitive_ReturnHerdName()
        {
            //arrange
            AnimalGroupName sut = new AnimalGroupName();

            //act
            string herdName = sut.GetHerd("Giraffe");

            //assert
            Assert.AreEqual("Tower", herdName);

        }
        //animal name not in dict return unknow
        [TestMethod]
        public void AnimalNameNotInDict_ReturnUnknown()
        {
            //arrange
            AnimalGroupName sut = new AnimalGroupName();

            //act
            string herdName = sut.GetHerd("horse");

            //assert
            Assert.AreEqual("unknown", herdName);

        }
        //null return unknown
        [TestMethod]
        public void AnimalNameNotInDict_ReturnNull()
        {
            //arrange
            AnimalGroupName sut = new AnimalGroupName();

            //act
            string herdName = sut.GetHerd("null");

            //assert
            Assert.AreEqual("unknown", herdName);
            //empty return unknown
        }
        //empty return unknown
        [TestMethod]
        public void AnimalNameEmpty_ReturnUnknown()
        {
            //arrange
            AnimalGroupName sut = new AnimalGroupName();

            //act
            string herdName = sut.GetHerd("");

            //assert
            Assert.AreEqual("unknown", herdName);

        }
    }
}
