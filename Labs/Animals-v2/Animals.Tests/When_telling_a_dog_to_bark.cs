using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Animals.Tests
{
    [TestClass]
    public class When_telling_a_dog_to_bark
    {
        [TestMethod]
        public void The_dog_does_not_bark_for_0_treats()
        {
            //Arrange
            var dog = new Dog();

            //Act
            var actualBarks = dog.Bark(0);
            var expectedBarks = new List<string>();

            //Assert
            Assert.IsTrue(actualBarks.Count == expectedBarks.Count, "Dog barked when it wasn't supposed to");
        }

        [TestMethod]
        public void The_dog_barks_once_for_1_treat()
        {
            //Arrange
            var dog = new Dog();

            //Act
            var actualBarks = dog.Bark(1);
            var expectedBarks = new List<string>()
                                {
                                    "Woof"
                                };

            //Assert
            Assert.IsTrue(actualBarks.Count == expectedBarks.Count, "Dog barked when it wasn't supposed to");
        }
    }
}
