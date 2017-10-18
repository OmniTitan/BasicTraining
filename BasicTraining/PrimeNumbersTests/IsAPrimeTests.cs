using NUnit.Framework;
using PrimeNumbersSolution;
using System;
using System.Collections.Generic;

namespace PrimeNumbersTests
{
    [TestFixture]
    public class IsAPrimeTests
    {
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
