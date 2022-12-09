namespace FigureSquares
{
    public abstract class AbstractFigure : IFigure
    {
        public abstract double CalculateSquare();

        protected abstract bool IsInvalid();
    }


}