using NUnit.Framework;
using System;

namespace AreaLib.Tests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 3)]
        [TestCase(3, 28)]
        public void AreaTest(int radius, int area)
        {
            var circle = new Circle(radius);

            var rounded = Math.Round(circle.GetArea());
            Assert.AreEqual(rounded, area);
        }

        [Test]
        [TestCase(-3, 28)]
        public void RadiusNegativeTest(int radius, int area)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}