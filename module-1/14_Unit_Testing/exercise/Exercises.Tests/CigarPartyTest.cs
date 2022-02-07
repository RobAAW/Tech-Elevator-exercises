using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]
        
        //A squirrel party is successful when the number of cigars is between 40 and 60
        public void AreThereEnoughCigarsNotWeekend()
        {
            //arrange
            CigarParty sut = new CigarParty();

            //act
            bool cigars41 = sut.HaveParty(41, false);

            //assert
            Assert.IsTrue(cigars41);
        }
        [TestMethod]
        public void AreThereEnoughCigarsIsWeekend()
        {
            //arrange
            CigarParty sut = new CigarParty();

            //act
            bool cigars71 = sut.HaveParty(71, true);

            //assert
            Assert.IsTrue(cigars71);
        }

        [TestMethod]
        public void NotEnoughCigarsNotWeekend()
        {
            //arrange
            CigarParty sut = new CigarParty();

            //act
            bool cigars39 = sut.HaveParty(39, false);

            //assert
            Assert.IsFalse(cigars39);
        }

        [TestMethod]
        public void NotEnoughCigarsIsWeekend()
        {
            //arrange
            CigarParty sut = new CigarParty();

            //act
            bool cigars39 = sut.HaveParty(39, true);

            //assert
            Assert.IsFalse(cigars39);
        }

        [TestMethod]
        public void ZeroCigarsIsWeekendSquirrelRiot()
        {
            //arrange
            CigarParty sut = new CigarParty();

            //act
            bool cigars0 = sut.HaveParty(0, true);

            //assert
            Assert.IsFalse(cigars0);
        }
    }
}
