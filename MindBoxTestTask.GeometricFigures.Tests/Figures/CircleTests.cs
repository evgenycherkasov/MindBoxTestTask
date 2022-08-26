using MindBoxTestTask.GeometricFigures.Implementations.Figures;

namespace MindBoxTestTask.GeometricFigures.Tests.Figures
{
    [TestFixture(Author = "E.Cherkasov")]
    public class CircleTests
    {
        private static IEnumerable<TestCaseData> GetDifferentCorrectRadiusWithAreas()
        {
            yield return new TestCaseData(1, Math.PI);
            yield return new TestCaseData(2, Math.PI * Math.Pow(2, 2));
        }

        private static IEnumerable<TestCaseData> GetDifferentCorrectRadiusWithPerimeters()
        {
            yield return new TestCaseData(1, 2 * Math.PI * 1);
            yield return new TestCaseData(2, 2 * Math.PI * 2);
        }

        private static IEnumerable<TestCaseData> GetDifferentCorrectRadiusWithDiameters()
        {
            yield return new TestCaseData(1, 1 * 2);
            yield return new TestCaseData(2, 2 * 2);
        }

        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        public void Ctor_Precondition_Throws(double radius)
        {
            //Act
            void Act()
            {
                var circle = new Circle(radius);
            }

            //Assert
            Assert.Catch(Act);
        }

        [Test]
        [TestCaseSource(typeof(CircleTests), nameof(GetDifferentCorrectRadiusWithAreas))]
        public void Area_DifferentRadius_ReturnsCorrectValues(double radius, double expectedArea)
        {
            //Arrange
            var circle = new Circle(radius);

            //Act
            var actualArea = circle.Area;

            //Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }

        [Test]
        [TestCaseSource(typeof(CircleTests), nameof(GetDifferentCorrectRadiusWithPerimeters))]
        public void Perimeter_DifferentRadius_ReturnsCorrectValues(double radius, double expectedPerimeter)
        {
            //Arrange
            var circle = new Circle(radius);

            //Act
            var actualPerimeter = circle.Perimeter;

            //Assert
            Assert.That(actualPerimeter, Is.EqualTo(expectedPerimeter));
        }

        [Test]
        [TestCaseSource(typeof(CircleTests), nameof(GetDifferentCorrectRadiusWithDiameters))]
        public void Diameter_DifferentRadius_ReturnsCorrectValues(double radius, double expectedDiameter)
        {
            //Arrange
            var circle = new Circle(radius);

            //Act
            var actualDiameter = circle.Diameter;

            //Assert
            Assert.That(actualDiameter, Is.EqualTo(expectedDiameter));
        }
    }
}