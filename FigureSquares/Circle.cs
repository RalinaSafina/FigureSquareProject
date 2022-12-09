namespace FigureSquares
{
    public class Circle : AbstractFigure
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
            if (IsInvalid())
                throw new Exception("Circle parameters should be positive numbers!");
        }

        public override double CalculateSquare()
        {
            return Math.PI * radius * radius;
        }

        protected override bool IsInvalid()
        {
            if (radius > 0)
                return false;
            return true;
        }
    }


}