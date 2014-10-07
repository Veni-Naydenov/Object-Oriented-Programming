namespace Shapes
{
    using System;

    class Circle : BasicShape, IShape
    {
        public Circle(decimal initialRadius)
            : base(initialRadius, initialRadius)
        {
        }

        public override decimal CalculateArea()
        {
            return (decimal)Math.PI * this.Height * this.Width;
        }

        public override decimal CalculatePerimeter()
        {
            return 2 * (decimal)Math.PI * this.Width;
        }
    }
}
