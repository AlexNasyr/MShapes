using NUnit.Framework;
using System;

namespace MShapes.Tests {
    [TestFixture]
    public class MShapesTests {
        [TestCase(new int[] { 1 }, 3.14159265)]
        [TestCase(new int[] { 2 }, 12.56637061)]
        [TestCase(new int[] { 3 }, 28.27433388)]
        [TestCase(new int[] { 4 }, 50.26548246)]
        [TestCase(new int[] { 5 }, 78.53981634)]
        public void TestCircle(int[] dim, double expected) {
            Assert.AreEqual(expected, new Circle(dim).Square(8), 0.000000010000001);
        }

        [TestCase(new int[] { 1, 1, 1 }, 0.43301270)]
        [TestCase(new int[] { 1, 2, 2 }, 0.96824584)]
        [TestCase(new int[] { 2, 3, 2 }, 1.98431348)]
        [TestCase(new int[] { 4, 4, 2 }, 3.87298335)]
        [TestCase(new int[] { 5, 5, 5 }, 10.82531755)]
        public void TestTriangle(int[] dim, double expected) {
            Assert.AreEqual(expected, new Triangle(dim).Square(8), 0.000000010000001);
        }

        [TestCase(new int[] { 1, 2, 1 })]
        public void TestTriangle_ThrowArgumentException(int[] dim)
            => Assert.Throws<ArgumentException>(() => new Triangle(dim).Square(8), "This triangle are not possible.");
        
        [TestCase(new int[] { 3, 4, 5 }, true)]
        public void TestTriangleRight(int[] dim, bool expected) {
            Assert.AreEqual(expected, new Triangle(dim).isTriangleRight());
        }

    }
}
