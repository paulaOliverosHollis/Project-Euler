using NUnit.Framework;
using Project_Euler;

namespace Tests
{
    [TestFixture]
    public class MathyHelper_UnitTests
    {
        [Test]
        [TestCase(-3, false)]
        [TestCase(-2, false)]
        [TestCase(-1, false)]
        [TestCase(0, false)]
        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(6, false)]
        [TestCase(7, true)]
        [TestCase(8, false)]
        [TestCase(9, false)]
        [TestCase(10, false)]
        [TestCase(11, true)]
        [TestCase(12, false)]
        [TestCase(13, true)]
        [TestCase(14, false)]
        [TestCase(15, false)]
        [TestCase(16, false)]
        [TestCase(17, true)]
        [TestCase(18, false)]
        [TestCase(19, true)]
        [TestCase(20, false)]
        [TestCase(21, false)]
        public void IsPrime_ReturnsExpectedResult(int number, bool expectedResult)
        {
            bool actualResult = MathyHelper.IsPrime(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("", false)]
        [TestCase("bob", true)]
        [TestCase("90009", true)]
        [TestCase(null, false)]
        [TestCase("racecar", true)]
        [TestCase("1234320", false)]
        [TestCase("123 321", true)]
        [TestCase("160861", false)]
        [TestCase("#", true)]
        [TestCase("  ", true)]
        public void IsPalendromic_ReturnsExpectedResult(string characters, bool expectedResult)
        {
            bool actualResult = MathyHelper.IsPalendromic(characters);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(232792560, true)]
        [TestCase(12, false)]
        [TestCase(232792561, false)]
        [TestCase(465585120, true)]
        public void IsDivisibleFrom1to20_ReturnsExpectedResult(int number, bool expectedResult)
        {
            bool actualResult = MathyHelper.IsDivisibleFrom1To20(number);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}