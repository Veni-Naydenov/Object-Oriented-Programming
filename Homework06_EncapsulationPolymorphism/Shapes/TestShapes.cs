namespace Shapes
{
    using System;
    using System.Collections.Generic;

    class TestShapes
    {
        static void Main()
        {
            Triangle triangle = new Triangle(10, 15, 20);

            Rectangle rectangle = new Rectangle(22, 10);

            Circle circle = new Circle(8);

            var listOfShapes = new List<IShape>() { triangle, rectangle, circle };

            foreach (var shape in listOfShapes)
            {
                Console.WriteLine("{0} area = {1}",
                    shape.GetType().Name,
                    shape.CalculateArea());
                Console.WriteLine("{0} perimeter = {1}\n",
                   shape.GetType().Name,
                   shape.CalculatePerimeter());
            }
        }
    }
}
