namespace Shapes
{
    public class Triangle : BasicShape, IShape
    {
        private decimal c = 0;

        public Triangle(decimal initialBase,
            decimal initialHeight)
            : base(initialBase, initialHeight)
        {
        }

        public Triangle(decimal initialBase,
            decimal initialASide,
            decimal initialCSide)
            : base(initialBase, initialASide)
        {
            this.C = initialCSide;
        }

        public decimal C
        {
            get
            {
                return this.c;
            }
            set
            {
                this.c = value;
            }
        }

        public override decimal CalculateArea()
        {
            decimal triangleBase = this.Width;
            decimal area = (triangleBase * this.Height) / 2;

            return area;
        }

        public override decimal CalculatePerimeter()
        {
            decimal perimeter = this.Width +
                this.Height +
                this.C;

            return perimeter;
        }
    }
}
