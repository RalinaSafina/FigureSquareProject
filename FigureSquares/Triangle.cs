namespace FigureSquares
{
    public class Triangle : AbstractFigure
    {
        public double side1;
        public double side2;
        public double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            if (IsInvalid())
                throw new Exception("A triangle with given sides does not exist!");
        }

        public override double CalculateSquare()
        {
            try
            {
                if (CheckIfRightTriangle())
                {
                    return RightTriangleSquare();
                }
                double partial_perimeter = (side1 + side2 + side3) / 2;
                return Math.Sqrt(partial_perimeter * (partial_perimeter - side1) *
                    (partial_perimeter - side2) * (partial_perimeter - side3));
            }
            catch
            {
                throw;
            }
        }

        protected override bool IsInvalid()
        {
            if (side1 < (side2 + side3) && side2 < (side1 + side3) && side3 < (side1 + side2) &&
                side1 > 0 && side2 > 0 && side3 > 0)
                return false;
            return true;
        }

        private double RightTriangleSquare()
        {
            if (Math.Pow(side1, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2))
                return side2 * side3 / 2;
            else if (Math.Pow(side2, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2))
                return side1 * side3 / 2;
            else
                return side1 * side2 / 2;
        }
        //Check if a triangle is right
        public bool CheckIfRightTriangle()
        {
            if (Math.Pow(side1, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2) ||
                    Math.Pow(side2, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2) ||
                    Math.Pow(side3, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2))
                return true;
            return false;
        }
    }


}