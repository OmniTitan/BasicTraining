using NUnit.Framework;
using PrimeNumbersSolution;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbersTests
{
    [TestFixture]
    class GetPrimesUpToNTests
    {
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
    }
}
