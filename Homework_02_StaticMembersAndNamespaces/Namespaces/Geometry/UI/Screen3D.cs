using System;

namespace Namespaces.Geometry.UI
{
    using point = Geometry3D;
    class Screen3D
    {
        private point.Point3D point3d = new point.Point3D();

        public void ViewPoint() 
        {
            Console.WriteLine(this.point3d);
        }
    }
}
