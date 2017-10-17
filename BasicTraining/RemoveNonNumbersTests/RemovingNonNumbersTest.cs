using NUnit.Framework;
using RemoveNonNumbersSolution;
using System;

namespace RemoveNonNumbersTests
{
    public class RemoveNonNumbersTest
    {
        [Test]
        public void ConvertingAString_ContainingOnlyNumbers_DoesNotThrowAnError()
        {
            Assert.DoesNotThrow(() => RemoveNonNumbers.Remove("0"));
        }

        [Test]
        public void ConvertingAString_ContainingLettersAndNumbers_DoesNotThrowAnError()
        {
            Assert.DoesNotThrow(() => RemoveNonNumbers.Remove("a0"));
        }

        [Test]
        public void ConvertingAString_ContainingOnlyNumbers_ResultsInCorrectCast()
        {
            var result = RemoveNonNumbers.Remove("0");

            Assert.AreEqual(0, result);
        }

        [Test]
        public void ConvertingAString_ContainingLettersAndNumbers_ResultsInCorrectCast()
        {
            var result = RemoveNonNumbers.Remove("0a");

            Assert.AreEqual(0, result);
        }

        [Test]
        public void ConvertingAComplexString_ContainingLettersAndNumbers_ResultsInCorrectCast()
        {
            var result = RemoveNonNumbers.Remove("7\"-272_7a4-1`¬|35");

            Assert.AreEqual(727274135, result);
        }

        [Test]
        public void ConvertingAString_ContainingAVeryLargeNumber_ThrowsAnInvalidCastException()
        {
            Assert.Throws<InvalidCastException>(() => RemoveNonNumbers.Remove("7727732526"));
        }

        [Test]
        public void ConvertingAString_WhichIsNull_ThrowsAnArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => RemoveNonNumbers.Remove(null));
        }

        [Test]
        public void ConvertingAString_WhichOnlyContainsLetters_ThrowsAnInvalidCastException()
        {
            Assert.Throws<InvalidCastException>(() => RemoveNonNumbers.Remove("aaa"));
        }

        [Test]
        public void ConvertingAString_WhichIsEmpty_ThrowsAnInvalidCastException()
        {
            Assert.Throws<InvalidCastException>(() => RemoveNonNumbers.Remove(""));
        }
    }
}
