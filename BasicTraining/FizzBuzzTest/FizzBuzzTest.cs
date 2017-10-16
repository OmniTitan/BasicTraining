using FizzBuzzSolution;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void Getting5NumbersShouldReturn5Values()
        {
            var results = FizzBuzz.PlayFizzBuzzUpTo(5);

            Assert.AreEqual(5, results.Count());
        }

        [Test]
        public void Getting5NumbersShouldMake11235()
        {
            var results = FizzBuzz.PlayFizzBuzzUpTo(5);

            Assert.AreEqual(new List<string> { "1", "2", "Fizz", "4", "Buzz" }, results);
        }

        [Test]
        public void Getting20NumbersShouldMakeSequence()
        {
            var results = FizzBuzz.PlayFizzBuzzUpTo(20);

            Assert.AreEqual(new List<string> {
                "1", "2", "Fizz", "4", "Buzz",
                "Fizz", "7", "8", "Fizz", "Buzz",
                "11", "Fizz", "13", "14", "FizzBuzz",
                "16", "17", "Fizz", "19", "Buzz"
            }, results);
        }

        [Test]
        public void GettingUpToZeroShouldReturnNoValues()
        {
            var results = FizzBuzz.PlayFizzBuzzUpTo(0);

            Assert.AreEqual(0, results.Count());
        }
        
        [Test]
        public void PlayingUpToNegativeValueReturnsNoValues()
        {
            var results = FizzBuzz.PlayFizzBuzzUpTo(0);

            Assert.AreEqual(0, results.Count());
        }
    }
}
