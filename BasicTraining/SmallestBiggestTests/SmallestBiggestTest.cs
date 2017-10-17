using NUnit.Framework;
using SmallestBiggestSolution;
using System;

namespace SmallestBiggestTests
{
    [TestFixture]
    public class SmallestBiggestTest
    {
        [Test]
        public void GetSmallest_FromEmptyArray_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SmallestBiggest.GetSmallest(new int[0]));
        }

        [Test]
        public void GetSmallest_FromPositiveArray_GetsSmallestValue()
        {
            Assert.AreEqual(3, SmallestBiggest.GetSmallest(new int[] { 12, 85, 6434, 3, 47 }));
        }

        [Test]
        public void GetSmallest_FromNegativeArray_GetsSmallestValue()
        {
            Assert.AreEqual(-634, SmallestBiggest.GetSmallest(new int[] { -12, -85, -634, -3, -47 }));
        }

        [Test]
        public void GetSmallest_FromMixedArray_GetsSmallestValue()
        {
            Assert.AreEqual(-82, SmallestBiggest.GetSmallest(new int[] { -12, -82, 636, -3, -47 }));
        }

        [Test]
        public void GetBiggest_FromEmptyArray_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => SmallestBiggest.GetBiggest(new int[0]));
        }

        [Test]
        public void GetBiggest_FromPositiveArray_GetsBiggestValue()
        {
            Assert.AreEqual(6434, SmallestBiggest.GetBiggest(new int[] { 12, 85, 6434, 3, 47 }));
        }

        [Test]
        public void GetBiggest_FromNegativeArray_GetsBiggestValue()
        {
            Assert.AreEqual(-3, SmallestBiggest.GetBiggest(new int[] { -12, -85, -634, -3, -47 }));
        }

        [Test]
        public void GetBiggest_FromMixedArray_GetsBiggestValue()
        {
            Assert.AreEqual(636, SmallestBiggest.GetBiggest(new int[] { -12, -82, 636, -3, -47 }));
        }
    }
}
