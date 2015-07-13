using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Animals.Tests
{
    [TestClass]
    public class When_telling_a_dog_to_bark
    {
        [TestMethod]
        public void The_dog_barks_once_for_1_treat()
        {
            //Arrange
            var dog = new Dog();
            
            //Act
            var responses = dog.Bark(1);

            var actualResponse = responses.FirstOrDefault();
            var expectedResponse = "Woof";

            //Assert
            Assert.AreEqual(expectedResponse, actualResponse);
            Assert.IsTrue(responses.Count == 1, "The number of responses from the dog did not equal 1 as expected.");
        }

        [TestMethod]
        public void The_dog_does_not_bark_for_0_treats()
        {
            //Arrange
            var dog = new Dog();

            //Act
            var responses = dog.Bark(0);

            var actualResponse = responses.FirstOrDefault();
            string expectedResponse = null;

            //Assert
            Assert.AreEqual(expectedResponse, actualResponse);
            Assert.IsTrue(responses.Count == 0, "The number of responses from the dog did not equal 0 as expected.");
        }
    }
}
