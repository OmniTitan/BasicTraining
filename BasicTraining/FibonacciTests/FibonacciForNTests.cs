using FibonacciSolution;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace FibonacciTests
{
    [TestFixture]
    class FibonacciForNTests
    {
        [Test]
        public void FibonacciForNNumbers_For5Numbers_StartsWithTwo1s()
        {
            var results = Fibonacci.DoFibonacciForNValues(5);

            Assert.AreEqual(new List<int> { 1, 1 }, results.Take(2));
        }

        [Test]
        public void FibonacciForNNumbers_For5Numbers_Gets5Values()
        {
            var results = Fibonacci.DoFibonacciForNValues(5);

            Assert.AreEqual(5, results.Count());
        }

        [Test]
        public void FibonacciForNNumbers_For5Numbers_MakesSequence()
        {
            var results = Fibonacci.DoFibonacciForNValues(5);

            Assert.AreEqual(new List<int> { 1, 1, 2, 3, 5 }, results);
        }

        [Test]
        public void FibonacciForNNumbers_For20Numbers_MakesSequence()
        {
            var results = Fibonacci.DoFibonacciForNValues(20);

            Assert.AreEqual(new List<int>
                { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 },
                results);
        }

        [Test]
        public void FibonacciForNNumbers_For0Numbers_ReturnsNoValues()
        {
            var results = Fibonacci.DoFibonacciForNValues(0);

            Assert.AreEqual(0, results.Count());
        }
    }
}
