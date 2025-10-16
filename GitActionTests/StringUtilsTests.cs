using GitAction;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitActionTests
{
    public class StringUtilsTests
    {
        [Test]
        public void Reverse_ReturnsReversedString()
        {
            Assert.That(StringUtils.Reverse("Hello"), Is.EqualTo("olleH"));
        }

        [Test]
        [TestCase("Level", true)]
        [TestCase("Hello", false)]
        public void IsPalindrome_WorksCorrectly(string input, bool expected)
        {
            Assert.That(StringUtils.IsPalindrome(input), Is.EqualTo(expected));
        }

        [Test]
        public void CountVowels_ReturnsCorrectCount()
        {
            Assert.That(StringUtils.CountVowels("Hello World"), Is.EqualTo(3));
        }
    }
}
