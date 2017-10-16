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
        public void Getting5NumbersShouldStartWithTwo1s()
        {
            var results = Fibonacci.DoFibonacciForNValues(5);

            Assert.AreEqual(new List<int> { 1, 1 }, results.Take(2));
        }

        [Test]
        public void Getting5NumbersShouldReturn5Values()
        {
            var results = Fibonacci.DoFibonacciForNValues(5);

            Assert.AreEqual(5, results.Count());
        }

        [Test]
        public void Getting5NumbersShouldMake11235()
        {
            var results = Fibonacci.DoFibonacciForNValues(5);

            Assert.AreEqual(new List<int> { 1, 1, 2, 3, 5 }, results);
        }

        [Test]
        public void Getting20NumbersShouldMakeSequence()
        {
            var results = Fibonacci.DoFibonacciForNValues(20);

            Assert.AreEqual(new List<int>
                { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 },
                results);
        }

        [Test]
        public void GettingUpTo1ShouldReturn2Values()
        {
            var results = Fibonacci.DoFibonacciUpTo(1);

            Assert.AreEqual(2, results.Count());
        }

        [Test]
        public void GettingUpToZeroShouldReturnNoValues()
        {
            var results = Fibonacci.DoFibonacciUpTo(0);

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void GettingUpToNegativeValueShouldReturnNoValues()
        {
            var results = Fibonacci.DoFibonacciUpTo(int.MinValue);

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void GettingUpTo200ShouldMakeSequence()
        {
            var results = Fibonacci.DoFibonacciForNValues(200);

            Assert.AreEqual(new List<int>
                { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 },
                results);
        }

        [Test]
        public void GettingZeroValuesShouldReturnNoValues()
        {
            var results = Fibonacci.DoFibonacciForNValues(0);

            Assert.AreEqual(0, results.Count());
        }

        [Test]
        public void GetNthFibonacciValueShouldGet1AtPosition1()
        {
            var result = Fibonacci.GetNthFibonacciValue(1);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void GettingNegativeNValueShouldThrowError()
        {
            Assert.Throws<ArgumentException>(() =>
                Fibonacci.GetNthFibonacciValue(int.MinValue)
                );
        }

        [Test]
        public void GettingZerothValueShouldThrowError()
        {
            Assert.Throws<ArgumentException>(() =>
                Fibonacci.GetNthFibonacciValue(0)
                );
        }

        [Test]
        public void GetNthFibonacciValueShouldGet1597AtPosition17()
        {
            var result = Fibonacci.GetNthFibonacciValue(17);

            Assert.AreEqual(1597, result);
        }
    }
}
