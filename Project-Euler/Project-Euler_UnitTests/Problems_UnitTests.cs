using NUnit.Framework;
using Project_Euler;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestFixture]
    public class Problems_UnitTests
    {
        [Test]
        [TestCase("233168")]
        public void Problem1_ReturnsExpectedResult(string expectedResult)
        {
            string actualResult = Problems.Problem1();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("4613732")]
        public void Problem2_ReturnsExpectedResult(string expectedResult)
        {
            string actualResult = Problems.Problem2();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("6857")]
        public void Problem3_ReturnsExpectedResult(string expectedResult)
        {
            string actualResult = Problems.Problem3();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("906609")]
        public void Problem4_ReturnsExpectedResult(string expectedResult)
        {
            string actualResult = Problems.Problem4();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("232792560")]
        public void Problem5_ReturnsExpectedResult(string expectedResult)
        {
            string actualResult = Problems.Problem5();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("25164150")]
        public void Problem6_ReturnsExpectedResult(string expectedResult)
        {
            string actualResult = Problems.Problem6();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("104743")]
        public void Problem7_ReturnsExpectedResult(string expectedResult)
        {
            string actualResult = Problems.Problem7();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
