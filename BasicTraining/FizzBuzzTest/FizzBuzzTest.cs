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
        public void PlayingFizzBuzz_With5Numbers_Returns5Values()
        {
            var results = FizzBuzz.PlayFizzBuzzUpTo(5);

            Assert.AreEqual(5, results.Count());
        }

        [Test]
        public void PlayingFizzBuzz_With5Numbers_MakesSequence()
        {
            var results = FizzBuzz.PlayFizzBuzzUpTo(5);

            Assert.AreEqual(new List<string> { "1", "2", "Fizz", "4", "Buzz" }, results);
        }

        [Test]
        public void PlayingFizzBuzz_With20Numbers_MakesSequence()
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
        public void PlayingFizzBuzz_With0Numbers_ReturnsNoValues()
        {
            var results = FizzBuzz.PlayFizzBuzzUpTo(0);

            Assert.AreEqual(0, results.Count());
        }
        
        [Test]
        public void PlayingFizzBuzz_WithNegativeNumberOfNumbers_ReturnsNoValues()
        {
            var results = FizzBuzz.PlayFizzBuzzUpTo(-5);

            Assert.AreEqual(0, results.Count());
        }
    }
}
