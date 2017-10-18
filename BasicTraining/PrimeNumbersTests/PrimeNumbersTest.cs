using NUnit.Framework;
using PrimeNumbersSolution;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbersTests
{
    [TestFixture]
    public class PrimeNumbersTest
    {
        [Test]
        public void GetFactors_Of1_DoesNotThrowAnError()
        {
            Assert.DoesNotThrow(() => PrimeNumbers.GetFactors(1));
        }

        [Test]
        public void GetFactors_OfNegativeNumber_ThrowsNotSupportedException()
        {
            Assert.Throws<NotSupportedException>(() => PrimeNumbers.GetFactors(-74), "Negative numbers are not supported. Technically, all negative numbers have the same factors as positive numbers, and positive numbers have both negative and positive factors, but let's keep things simple and not support negative numbers");
        }

        [Test]
        public void GetFactors_Of0_GetsEmptyList()
        {
            var results = PrimeNumbers.GetFactors(0);

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void GetFactors_For1_GetsFactors()
        {
            var results = PrimeNumbers.GetFactors(1);

            Assert.AreEqual(
                new List<int> { 1 }, results);
        }

        [Test]
        public void GetFactors_For96_GetsFactors()
        {
            var results = PrimeNumbers.GetFactors(96);

            Assert.AreEqual(
                new List<int> { 1, 2, 3, 4, 6, 8, 12, 16, 24, 32, 48, 96 }, results);
        }

        [Test]
        public void GetFactors_For84_GetsFactors()
        {
            var results = PrimeNumbers.GetFactors(1);

            Assert.AreEqual(
                new List<int> { 1, 2, 3, 4, 6, 7, 12, 14, 21, 28, 42, 84 }, results);
        }
        
        [Test]
        public void GetNPrimes_1Prime_DoesNotThrowAnError()
        {
            Assert.DoesNotThrow(() => PrimeNumbers.GetNPrimes(1));
        }

        [Test]
        public void GetNPrimes_NegativeNumberOfPrimes_ThrowsArgumentException()
        {
            Assert.Throws<NotSupportedException>(() => PrimeNumbers.GetNPrimes(-1));
        }

        [Test]
        public void GetNPrimes_0Primes_ReturnsEmptyList()
        {
            var results = PrimeNumbers.GetNPrimes(0);

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void GetNPrimes_1Prime_GetsPrimes()
        {
            var results = PrimeNumbers.GetNPrimes(1);

            Assert.AreEqual(
                new List<int> { 2 }, results);
        }

        [Test]
        public void GetNPrimes_For3_GetsPrimes()
        {
            var results = PrimeNumbers.GetNPrimes(3);

            Assert.AreEqual(
                new List<int> { 2, 3, 5 }, results);
        }

        [Test]
        public void GetNPrimes_16Primes_GetsPrimes()
        {
            var results = PrimeNumbers.GetNPrimes(16);

            Assert.AreEqual(
                new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 49 }, results);
        }

        [Test]
        public void GetPrimesUpToN_UpTo1_DoesNotThrowAnError()
        {
            Assert.DoesNotThrow(() => PrimeNumbers.GetPrimesUpTo(1));
        }

        [Test]
        public void GetPrimesUpToN_UpToNegativeNumber_DoesNotThrowAnError()
        {
            Assert.DoesNotThrow(() => PrimeNumbers.GetPrimesUpTo(-1));
        }

        [Test]
        public void GetPrimesUpToN_UpTo0_ReturnsEmptyList()
        {
            var results = PrimeNumbers.GetPrimesUpTo(0);

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void GetPrimesUpToN_UpToMinus12_ReturnsEmptyList()
        {
            var results = PrimeNumbers.GetPrimesUpTo(-12);

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void GetPrimesUpToN_UpTo1_ReturnsEmptyList()
        {
            var results = PrimeNumbers.GetPrimesUpTo(1);

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void GetPrimesUpToN_UpTo3_GetsPrimes()
        {
            var results = PrimeNumbers.GetPrimesUpTo(3);

            Assert.AreEqual(new List<int> { 2, 3 }, results);
        }

        [Test]
        public void GetPrimesUpToN_UpTo16_GetsPrimes()
        {
            var results = PrimeNumbers.GetPrimesUpTo(16);

            Assert.AreEqual(
                new List<int> { 2, 3, 5, 7, 11, 13 }, results);
        }

        [Test]
        public void GetIsAPrime_For1_DoesNotThrowAnError()
        {
            Assert.DoesNotThrow(() => PrimeNumbers.IsAPrimeNumber(1));
        }

        [Test]
        public void GetIsAPrime_ForNegativeNumber_ThrowsNotSupportedException()
        {
            Assert.Throws<NotSupportedException>(() => PrimeNumbers.IsAPrimeNumber(-1));
        }

        [Test]
        public void GetIsAPrime_For0_ReturnsFalse()
        {
            var results = PrimeNumbers.IsAPrimeNumber(0);

            Assert.IsFalse(results);
        }

        [Test]
        public void GetIsAPrime_For1_ReturnsFalse()
        {
            var results = PrimeNumbers.IsAPrimeNumber(1);

            Assert.IsFalse(results);
        }

        [Test]
        public void GetIsAPrime_For3_ReturnsTrue()
        {
            var results = PrimeNumbers.IsAPrimeNumber(3);

            Assert.IsTrue(results);
        }

        [Test]
        public void GetIsAPrime_UpTo16_GetsPrimes()
        {
            var results = PrimeNumbers.IsAPrimeNumber(16);

            Assert.IsFalse(results);
        }
    }
}
