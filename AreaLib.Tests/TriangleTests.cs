using NUnit.Framework;
using System;

namespace AreaLib.Tests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(3, 4, 5, 6)]
        public void AreaTest(int a, int b, int c, int area)
        {
            var triangle = new Triangle(a, b, c);

            var rounded = Math.Round(triangle.GetArea());
            Assert.AreEqual(rounded, area);
        }

        [Test]
        [TestCase(-3, 4, 5)]
        public void SidesNegativeTest(int a, int b, int c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }


        [Test]
        [TestCase(3, 4, 5)]
        public void IsRightTest(int a, int b, int c)
        {
            var triangle = new Triangle(a, b, c);

            Assert.IsTrue(triangle.IsRight());
        }

        [Test]
        [TestCase(3, 4, 6)]
        public void IsNotRightTest(int a, int b, int c)
        {
            var triangle = new Triangle(a, b, c);

            var isRight = triangle.IsRight();
            Assert.IsFalse(isRight);
        }
    }
}
