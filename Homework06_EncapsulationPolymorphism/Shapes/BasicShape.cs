namespace Shapes
{
    public abstract class BasicShape : IShape
    {
        private decimal width = 0;
        private decimal height = 0;

        protected BasicShape(decimal initialWidth, decimal initialHeight)
        {
            this.Width = initialWidth;
            this.Height = initialHeight;
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public abstract decimal CalculateArea();

        public abstract decimal CalculatePerimeter();
    }
}
