using NUnit.Framework;
using FibonacciSolution;
using System;

namespace FibonacciTests
{
    [TestFixture]
    public class NthFibonacciTests
    {
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
