namespace Shapes
{
    public class Rectangle : BasicShape, IShape
    {
        public Rectangle(decimal initialWidth,
            decimal initialHeight)
            : base(initialWidth, initialHeight)
        {
        }

        public override decimal CalculateArea()
        {
            decimal area = this.Width * this.Height;

            return area;
        }

        public override decimal CalculatePerimeter()
        {
            decimal perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }
    }
}
