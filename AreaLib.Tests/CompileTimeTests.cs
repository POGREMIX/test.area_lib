using NUnit.Framework;
using System;

namespace AreaLib.Tests
{
    public class CompileTimeTests
    {
        [Test]
        [TestCase(3, 28)]
        public void AreaPositiveTest(int radius, int area)
        {
            dynamic obj = new Circle(radius);
            var rounded = Math.Round(Figure.GetArea(obj));

            Assert.AreEqual(rounded, area);
        }

        [Test]
        public void AreaNegativeTest()
        {
            dynamic obj = "COMPILE TIME TYPE CHECK";
            Assert.Throws<ArgumentException>(() => Figure.GetArea(obj));
        }
    }
}
