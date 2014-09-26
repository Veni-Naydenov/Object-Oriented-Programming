namespace Point3dDistancePath._01._3DPoint
{
    using System;

    public class Point3D
    {
        private int x = 0;
        private int y = 0;
        private int z = 0;
        private static readonly Point3D zeroPoint = new Point3D();

        public Point3D()
            : this(0, 0, 0)
        {

        }

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3D ZeroPoint
        {
            get
            {
                return zeroPoint;
            }
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public int Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", this.x, this.y, this.z);
        }
    }
}
