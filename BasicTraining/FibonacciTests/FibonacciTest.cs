using NUnit.Framework;
using FibonacciSolution;
using System.Linq;
using System.Collections.Generic;
using System;

namespace FibonacciTests
{
    [TestFixture]
    public class FibonacciTest
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

        [Test]
        public void GetNthFibonacci_1stValue_Gets1()
        {
            var result = Fibonacci.GetNthFibonacciValue(1);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetNthFibonacci_2ndValue_Gets1()
        {
            var result = Fibonacci.GetNthFibonacciValue(2);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetNthFibonacci_NegativeN_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                Fibonacci.GetNthFibonacciValue(int.MinValue)
                );
        }

        [Test]
        public void GetNthFibonacci_0thValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
                Fibonacci.GetNthFibonacciValue(0)
                );
        }

        [Test]
        public void GetNthFibonacci_17thValue_Gets1597()
        {
            var result = Fibonacci.GetNthFibonacciValue(17);

            Assert.AreEqual(1597, result);
        }
    }
}
