namespace Namespaces
{
    using System;
    using Geometry.Geometry2D;
    using Geometry.Geometry3D;
    using Geometry.Storage;
    using Geometry.UI;

    class Namespaces
    {
        static void Main()
        {
            Circle circle = new Circle();
            Path3D path = new Path3D();
            GeometrySVGStorage svg = new GeometrySVGStorage();
            Screen3D screen = new Screen3D();

            screen.ViewPoint();
        }
    }
}
