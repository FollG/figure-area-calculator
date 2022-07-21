using calcSquare;

namespace CalcSquare.NUnitTest
{
    public class Tests
    {
        private Circle _circe;   
        private Triangle _triangle;

        [SetUp]
        public void Setup()
        {
            _circe = new Circle(2);
            _triangle = new Triangle(6, 8, 10);
        }

        [Test]
        public void Square_2_Requared_12_57()
        {
            double circleResult = _circe.Calc();
            Assert.That(circleResult, Is.EqualTo(12.57));
        }

        [Test]
        public void Square_6_8_10_Requared_24_0()
        {
            double triangleResult = _triangle.Calc();
            Assert.That(triangleResult, Is.EqualTo(24.0));
        }

        [Test]
        public void IsRectangle_Requared_True()
        {
            bool triangleResult = _triangle.IsRectangular();
            Assert.That(triangleResult, Is.EqualTo(true));
        }
    }
}