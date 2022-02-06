using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        //Given an array of strings, return a Dictionary<string, int> with a key for each different
        //string, with the value the number of times that string appears in the array.
        //Dictionary<string, int> GetCount(string[] words)


        [TestMethod]
        public void AppearsOnce()
        {
            //arrange
            WordCount sut = new WordCount();

            //act
            Dictionary<string, int> output = new Dictionary<string, int>() { { "Super", 1 }, { "Mario", 1 }, { "Bros", 1 } };
            string[] words = new string[] { "Super", "Mario", "Bros" };

            Dictionary<string, int> compare = sut.GetCount(words);

            //assert
            CollectionAssert.AreEqual(output, compare);
        }

        [TestMethod]
        public void AppearsMoreThanOnce()
        {
            //arrange
            WordCount sut = new WordCount();

            //act
            Dictionary<string, int> output = new Dictionary<string, int>() { { "Dance", 2 }, { "Revolution", 1 } };
            string[] words = new string[] { "Dance", "Dance", "Revolution" };

            Dictionary<string, int> compare = sut.GetCount(words);

            //assert
            CollectionAssert.AreEqual(output, compare);
        }

        [TestMethod]
        public void StringIsEmpty()
        {
            //arrange
            WordCount sut = new WordCount();

            //act
            Dictionary<string, int> output = new Dictionary<string, int>() { { "", 2 }, { "Hades", 1 } };
            string[] words = new string[] { "", "Hades", "" };

            Dictionary<string, int> compare = sut.GetCount(words);

            //assert
            CollectionAssert.AreEqual(output, compare);
        }

        [TestMethod]
        public void NumberStringsDoNotMatch()
        {
            //arrange
            WordCount sut = new WordCount();

            //act
            Dictionary<string, int> output = new Dictionary<string, int>() { { "2147483647", 2 }, { "Metroid", 1 } };
            string[] words = new string[] { "2147483647", "Hades", "2137483647" };

            Dictionary<string, int> compare = sut.GetCount(words);

            //assert
            CollectionAssert.AreNotEqual(output, compare);
        }

    }
}
