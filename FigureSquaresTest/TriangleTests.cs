using FigureSquares;

namespace FigureSquaresTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void CalculateSquare_RightTriangleTest()
        {
            double expected = 6;
            Triangle triangle = new(3, 4, 5);
            double actual = triangle.CalculateSquare();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateSquare_Test()
        {
            double expected = 3.897114317029974;
            Triangle triangle = new(3, 3, 3);
            double actual = triangle.CalculateSquare();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfRightTriangle_Test()
        {
            bool expected = true;
            Triangle triangle = new(3, 4, 5);
            bool actual = triangle.CheckIfRightTriangle();
            Assert.AreEqual(expected, actual);
        }
    }
}
