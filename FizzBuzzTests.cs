using NUnit.Framework;
using System.Collections.Generic;
using FizzBuzzApp;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void ProcessFizzBuzz_ShouldReturnCorrectResults()
        {
            // Arrange
            List<string> inputs = new List<string> { "1", "3", "5", "", "15", "A", "23" };
            List<string> expectedResults = new List<string>
            {
                "Divided 1 by 3",
                "Divided 1 by 5",
                "Fizz",
                "Buzz",
                "Invalid item",
                "FizzBuzz",
                "Invalid item",
                "Divided 23 by 3",
                "Divided 23 by 5"
            };

            // Act
            List<string> actualResults = FizzBuzz.ProcessFizzBuzz(inputs);

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }
    }
}