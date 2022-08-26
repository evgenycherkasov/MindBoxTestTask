using MindBoxTestTask.GeometricFigures.Implementations.Figures;

namespace MindBoxTestTask.GeometricFigures.Tests.Figures
{
    public class TriangleTests
    {
        [Test]
        [TestCase(-1, 1, 2)]
        [TestCase(2, -1, 2)]
        [TestCase(3, 2, 0)]
        [TestCase(10, 2, 8)]
        public void Ctor_Precondition_Throws(double sideA, double sideB, double sideC)
        {
            //Act
            void Act()
            {
                var triangle = new Triangle(sideA, sideB, sideC);
            }

            //Assert
            Assert.Catch(Act);
        }

        [Test]
        [TestCase(3, 4, 5, 6)]
        [TestCase(12, 10, 10, 48)]
        public void Area_CorrectSides_ReturnsCorrectValues(double sideA, double sideB, double sideC, double expectedArea)
        {
            //Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            //Act
            var actualArea = triangle.Area;

            //Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [TestCase(3, 4, 5, 12)]
        [TestCase(12, 10, 10, 32)]
        public void Perimeter_CorrectSides_ReturnsCorrectValues(double sideA, double sideB, double sideC, double expectedPerimeter)
        {
            //Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            //Act
            var actualPerimeter = triangle.Perimeter;

            //Assert
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }

        [Test]
        [TestCase(3, 4, 5, true)]
        [TestCase(12, 10, 10, false)]
        public void IsRightAngled_CorrectSides_ReturnsCorrectValues(double sideA, double sideB, double sideC, bool expectedResult)
        {
            //Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            //Act
            var isRightAngled = triangle.IsRightAngled;

            //Assert
            Assert.That(isRightAngled, Is.EqualTo(expectedResult));
        }
    }
}