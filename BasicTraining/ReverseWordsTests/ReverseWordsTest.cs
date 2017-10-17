using NUnit.Framework;
using ReverseWordsSolution;
using System;

namespace ReverseWordsTests
{
    [TestFixture]
    public class ReverseWordsTest
    {
        [Test]
        public void Reversing_1Word_DoesNotChangeLengthOfWord()
        {
            var result = ReverseWords.Reverse("asdf");

            Assert.AreEqual(4, result.Length);
        }

        [Test]
        public void Reversing_1Word_ReversesTheWord()
        {
            var result = ReverseWords.Reverse("asdf");

            Assert.AreEqual("fdsa", result);
        }

        [Test]
        public void Reversing_2Words_ReversesEachWordSeperately()
        {
            var result = ReverseWords.Reverse("Good morning!");

            Assert.AreEqual("dooG !gninrom", result);
        }

        [Test]
        public void Reversing_AnEmptySentence_ReturnsAnEmptySentence()
        {
            var result = ReverseWords.Reverse("");

            Assert.AreEqual("", result);
        }

        [Test]
        public void Reversing_ANullSentence_ThrowsAnArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => ReverseWords.Reverse(null));
        }
    }
}
