using FibonacciSolution;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciTests
{
    [TestFixture]
    class FibonacciUpToNTests
    {

        [Test]
        public void FibonacciUpToN_UpTo1_Gets2Numbers()
        {
            var results = Fibonacci.DoFibonacciUpTo(1);

            Assert.AreEqual(2, results.Count());
        }

        [Test]
        public void FibonacciUpToN_UpTo0_Gets0Numbers()
        {
            var results = Fibonacci.DoFibonacciUpTo(0);

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void FibonacciUpToN_UpToNegativeNumber_Gets0Numbers()
        {
            var results = Fibonacci.DoFibonacciUpTo(int.MinValue);

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void FibonacciUpToN_UpTo200_MakesSequence()
        {
            var results = Fibonacci.DoFibonacciUpTo(200);

            Assert.AreEqual(new List<int>
                { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 },
                results);
        }
    }
}
