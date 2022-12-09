namespace FigureSquares
{
    public interface IFigureService
    {
        public double CalculateSquare<T>(T figure) where T : IFigure;
    }
}
