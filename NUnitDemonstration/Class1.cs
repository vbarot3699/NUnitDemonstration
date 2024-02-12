using NUnit.Framework;

namespace NUnitDemonstration
{
    [TestFixture]
    public class TriangleTests
    {
        // Test for a valid equilateral triangle
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage()
        {
       
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            
            Assert.AreEqual("The triangle is valid.", result);
        }

        // Test for an invalid triangle with angle sum less than 180
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            
            int firstAngle = 90;
            int secondAngle = 90;
            int thirdAngle = 0;

            
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            
            Assert.AreEqual("The triangle is not valid.", result);
        }

        // Test for an invalid triangle with angle sum greater than 180
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage2()
        {
            
            int firstAngle = 30;
            int secondAngle = 60;
            int thirdAngle = 95;

            
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            
            Assert.AreEqual("The triangle is not valid.", result);
        }

        // Test for an invalid triangle with negative angle
        [Test]
        public void ValidTriangle_AnotherInvalidInput_ReturnsInvalidMessage()
        {
            
            int firstAngle = 120;
            int secondAngle = 60;
            int thirdAngle = 5;

            
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            
            Assert.AreEqual("The triangle is not valid.", result);
        }

        // Test for a triangle with a zero angle
        [Test]
        public void TriangleWithZeroAngle_ReturnsInvalidMessage()
        {
            
            int firstAngle = 0;
            int secondAngle = 60;
            int thirdAngle = 120;

            
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            
            Assert.AreEqual("The triangle is not valid.", result);
        }

        // Test for a triangle with a negative angle
        [Test]
        public void TriangleWithNegativeAngle_ReturnsInvalidMessage()
        {
            
            int firstAngle = 30;
            int secondAngle = -60;
            int thirdAngle = 150;

            
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            
            Assert.AreEqual("The triangle is not valid.", result);
        }

        // Test for a triangle with a negative value angle
        [Test]
        public void TriangleWithNegativeValueAngle_ReturnsInvalidMessage()
        {
            
            int firstAngle = 80;
            int secondAngle = -60;
            int thirdAngle = 100;

            
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            
            Assert.AreEqual("The triangle is not valid.", result);
        }

        // Test for a valid triangle with an obtuse angle
        [Test]
        public void TriangleWithObtuseAngle_ReturnsValidMessage()
        {
            
            int firstAngle = 45;
            int secondAngle = 45;
            int thirdAngle = 90;

            
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            
            Assert.AreEqual("The triangle is valid.", result);
        }

        // Test for an invalid triangle with angle sum greater than 180
        [Test]
        public void TriangleWithLargeAngleSum_ReturnsInvalidMessage()
        {
            
            int firstAngle = 120;
            int secondAngle = 70;
            int thirdAngle = 30;

            
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            
            Assert.AreEqual("The triangle is not valid.", result);
        }

        // Test for a valid triangle with three equal angles
        [Test]
        public void TriangleWithEqualAngles_ReturnsValidMessage()
        {
            
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            
            Assert.AreEqual("The triangle is valid.", result);
        }

        // Test for a valid triangle with two equal angles
        [Test]
        public void TriangleWithTwoEqualAngles_ReturnsValidMessage()
        {
            
            int firstAngle = 45;
            int secondAngle = 90;
            int thirdAngle = 45;

            
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            
            Assert.AreEqual("The triangle is valid.", result);
        }

        // Test for a valid triangle with three different angles
        [Test]
        public void TriangleWithThreeDifferentAngles_ReturnsValidMessage()
        {
            
            int firstAngle = 30;
            int secondAngle = 60;
            int thirdAngle = 90;

            
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            
            Assert.AreEqual("The triangle is valid.", result);
        }
    }
}

