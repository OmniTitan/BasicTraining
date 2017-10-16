using NUnit.Framework;
using ReverseWordsSolution;
using System;

namespace ReverseWordsTests
{
    [TestFixture]
    public class FizzBuzzTest
    {
        [Test]
        public void ReversingAWordShouldNotChangeLengthOfWord()
        {
            var result = ReverseWords.Reverse("asdf");

            Assert.AreEqual(4, result.Length);
        }

        [Test]
        public void Reversing1WordShouldReverse()
        {
            var result = ReverseWords.Reverse("asdf");

            Assert.AreEqual("fdsa", result);
        }

        [Test]
        public void Reversing2WordsShouldReverseEachWordSeperately()
        {
            var result = ReverseWords.Reverse("Good morning!");

            Assert.AreEqual("dooG !gninrom", result);
        }

        [Test]
        public void ReversingAnEmptySentenceShouldReturnAnEmptySentence()
        {
            var result = ReverseWords.Reverse("");

            Assert.AreEqual("", result);
        }

        [Test]
        public void ReversingANullSentenceShouldThrowAnArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => ReverseWords.Reverse(null));
        }
    }
}
