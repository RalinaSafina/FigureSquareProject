using FigureSquares;

namespace FigureSquaresTest
{

    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CalculateSquare_Test()
        {
            double expected = Math.PI;
            Circle circle = new(1);
            double actual = circle.CalculateSquare();
            Assert.AreEqual(expected, actual);
        }
    }
}