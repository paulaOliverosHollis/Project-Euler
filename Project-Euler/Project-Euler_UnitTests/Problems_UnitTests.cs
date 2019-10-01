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
        public void Problem1_ReturnsExpectedResult()
        {
            string actualResult = Problems.Problem1();

            Assert.AreEqual("233168", actualResult);
        }

        [Test]
        public void Problem2_ReturnsExpectedResult()
        {
            string actualResult = Problems.Problem2();

            Assert.AreEqual("4613732", actualResult);
        }

        [Test]
        public void Problem3_ReturnsExpectedResult()
        {
            string actualResult = Problems.Problem3();

            Assert.AreEqual("6857", actualResult);
        }

        [Test]
        public void Problem4_ReturnsExpectedResult()
        {
            string actualResult = Problems.Problem4();

            Assert.AreEqual("906609", actualResult);
        }

        [Test]
        public void Problem5_ReturnsExpectedResult()
        {
            string actualResult = Problems.Problem5();

            Assert.AreEqual("232792560", actualResult);
        }

        [Test]
        public void Problem6_ReturnsExpectedResult()
        {
            string actualResult = Problems.Problem6();

            Assert.AreEqual("25164150", actualResult);
        }

        [Test]
        public void Problem7_ReturnsExpectedResult()
        {
            string actualResult = Problems.Problem7();

            Assert.AreEqual("104743", actualResult);
        }
    }
}
