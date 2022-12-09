using FigureSquares;

namespace FigureSquaresTest
{
    [TestClass]
    public class FigureServiceTests
    {
        [TestMethod]
        public void CalculateSquareT_Test()
        {
            double expected = 6;
            IFigureService figureService = new FigureService();
            Triangle triangle = new(3, 4, 5);
            double actual = figureService.CalculateSquare(triangle);
            Assert.AreEqual(expected, actual);
        }
    }
}
