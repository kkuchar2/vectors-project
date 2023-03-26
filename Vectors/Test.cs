using NUnit.Framework;

namespace Vectors
{
    [TestFixture]
    public class WektorTests
    {
        [Test]
        public void TestVectorAddition()
        {
            // Arrange
            var v1 = new Wektor(1, 2, 3);
            var v2 = new Wektor(4, 5, 6);

            // Act
            var result = v1 + v2;

            // Assert
            Assert.AreEqual(new Wektor(5, 7, 9), result);
        }

        [Test]
        public void TestVectorSubtraction()
        {
            // Arrange
            var v1 = new Wektor(1, 2, 3);
            var v2 = new Wektor(4, 5, 6);

            // Act
            var result = v1 - v2;

            // Assert
            Assert.AreEqual(new Wektor(-3, -3, -3), result);
        }

        [Test]
        public void TestVectorScalarMultiplication()
        {
            // Arrange
            var v1 = new Wektor(1, 2, 3);
            var d = 2;

            // Act
            var result = v1 * d;

            // Assert
            Assert.AreEqual(new Wektor(2, 4, 6), result);
        }

        [Test]
        public void TestVectorDotProduct()
        {
            // Arrange
            var v1 = new Wektor(1, 2, 3);
            var v2 = new Wektor(4, 5, 6);

            // Act
            var result = Wektor.Dot(v1, v2);

            // Assert
            Assert.AreEqual(32, result);
        }

        [Test]
        public void TestVectorCrossProduct()
        {
            // Arrange
            var v1 = new Wektor(1, 2, 3);
            var v2 = new Wektor(4, 5, 6);

            // Act
            var result = Wektor.Cross(v1, v2);

            // Assert
            Assert.AreEqual(new Wektor(-3, 6, -3), result);
        }

        [Test]
        public void TestVectorEquality()
        {
            // Arrange
            var v1 = new Wektor(1, 2, 3);
            var v2 = new Wektor(1, 2, 3);
            var v3 = new Wektor(4, 5, 6);

            // Assert
            Assert.AreEqual(v1, v2);
            Assert.AreNotEqual(v1, v3);
        }

        [Test]
        public void TestVectorComparison()
        {
            // Arrange
            var v1 = new Wektor(1, 2, 3);
            var v2 = new Wektor(4, 5, 6);
            var v3 = new Wektor(7, 8, 9);

            // Assert
            Assert.AreEqual(-1, v1.CompareTo(v3));
            Assert.AreEqual(0, v2.CompareTo(v2));
            Assert.AreEqual(1, v3.CompareTo(v2));
        }

        [Test]
        public void TestVectorOrthogonality()
        {
            // Arrange
            var v1 = new Wektor(1, 0, 0);
            var v2 = new Wektor(0, 1, 0);
            var v3 = new Wektor(1, 1, 1);

            // Assert
            Assert.IsTrue(Wektor.IsOrthogonal(v1, v2));
            Assert.IsFalse(Wektor.IsOrthogonal(v1, v3));
        }
    }
}
        
        