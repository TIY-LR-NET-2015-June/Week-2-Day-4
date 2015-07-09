using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace Challenge1.Tests
{
    [TestClass]
    public class Challlenge1_UnitTests
    {
        [TestMethod]
        public void The_change_for_39_is_1_Quarter_1_Dime_4_Pennies()
        {
            //Arrange
            var changeFactory = new ChangeFactory();

            //Act
            var actualChangeItems = changeFactory.MakeChange(39);
            var expectedChangeItems = new List<int>()
            {
                25,
                10,
                1,
                1,
                1,
                1,
            };

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual(expectedChangeItems, actualChangeItems), "The change lists did not match.");
        }
        
        [TestMethod]
        public void The_change_for_negative_1_is_none()
        {

        }
    }
}
