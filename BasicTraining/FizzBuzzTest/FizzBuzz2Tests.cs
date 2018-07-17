using FizzBuzzSolution;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzz2Tests
    {
        [Test]
        public void PlayingFizzBuzz_With5Numbers_Returns5Values()
        {
            var settings = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" }
            };

            var results = FizzBuzz.PlayFizzBuzz2UpTo(5, settings);

            Assert.AreEqual(5, results.Count());
        }
        [Test]
        public void PlayingFizzBuzz_With15Numbers_MakesSequence()
        {
            var settings = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" }
            };

            var results = FizzBuzz.PlayFizzBuzz2UpTo(15, settings);

            Assert.AreEqual(new List<string>
            {
                "1", "2", "Fizz", "4", "Buzz",
                "Fizz", "7", "8", "Fizz", "Buzz",
                "11", "Fizz", "13", "14", "FizzBuzz"
            }, results);
        }

        [Test]
        public void PlayingRedGreenBlue_With32Numbers_MakesSequence()
        {
            var settings = new Dictionary<int, string>
            {
                { 2, "Red" },
                { 3, "Green" },
                { 5, "Blue" }
            };

            var results = FizzBuzz.PlayFizzBuzz2UpTo(32, settings);

            Assert.AreEqual(new List<string>
            {
                "1", "Red", "Green", "Red", "Blue",
                "RedGreen", "7", "Red", "Green", "RedBlue",
                "11", "RedGreen", "13", "Red", "GreenBlue",
                "Red", "17", "RedGreen", "19", "RedBlue",
                "Green", "Red", "23", "RedGreen", "Blue",
                "Red", "Green", "Red", "29", "RedGreenBlue",
                "31", "Red"
            }, results);
        }

        [Test]
        public void PlayingBigSmall_With20Numbers_MakesSequence()
        {
            var settings = new Dictionary<int, string>
            {
                { 3, "Big" },
                { 4, "Small" }
            };

            var results = FizzBuzz.PlayFizzBuzz2UpTo(20, settings);

            Assert.AreEqual(new List<string> {
                "1", "2", "Big", "Small", "5",
                "Big", "7", "Small", "Big", "10",
                "11", "BigSmall", "13", "14", "Big",
                "Small", "17", "Big", "19", "Small"
            }, results);
        }

        [Test]
        public void PlayingBigSmall_WithDictionarySwappedAnd12Numbers_MakesUnaffectedSequence()
        {
            var settings = new Dictionary<int, string>
            {
                { 4, "Small" },
                { 3, "Big" }
            };

            var results = FizzBuzz.PlayFizzBuzz2UpTo(12, settings);

            Assert.AreEqual(new List<string> {
                "1", "2", "Big", "Small", "5",
                "Big", "7", "Small", "Big", "10",
                "11", "BigSmall"
            }, results);
        }

        [Test]
        public void PlayingFizzBuzz_With5NumbersAndEmptySettings_ReturnsUntouchedValues()
        {
            var results = FizzBuzz.PlayFizzBuzz2UpTo(5, new Dictionary<int, string>());

            Assert.AreEqual(new List<string>
            {
                "1", "2", "3", "4", "5"
            }, results);
        }

        [Test]
        public void PlayingFizzBuzz_With0Numbers_ReturnsNoValues()
        {
            var results = FizzBuzz.PlayFizzBuzz2UpTo(0, new Dictionary<int, string>());

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void PlayingFizzBuzz_WithNegativeNumberOfNumbers_ReturnsNoValues()
        {
            var results = FizzBuzz.PlayFizzBuzz2UpTo(-5, new Dictionary<int, string>());

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void PlayingFizzBuzz_WithNullSettings_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var results = FizzBuzz.PlayFizzBuzz2UpTo(5, null).ToList();
            });
        }
    }
}
