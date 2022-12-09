namespace FigureSquares
{
    public class FigureService : IFigureService
    {
        public double CalculateSquare<T>(T figure) where T : IFigure
        {
            return figure.CalculateSquare();
        }
    }
}
