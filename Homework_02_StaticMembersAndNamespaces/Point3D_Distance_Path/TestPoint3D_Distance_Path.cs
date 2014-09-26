namespace Point3dDistancePath
{
    using System;
   
    using Point3dDistancePath._01._3DPoint;
    using Point3dDistancePath._02.Distance;
    using Point3dDistancePath._03.Path3D;

    class TestPoint3D_Distance_Path
    {
        static void Main()
        {
            //01.Test Point3D
            Console.WriteLine("\ttask 1: Test Point3D\n");

            Point3D startPoint = new Point3D();
            Console.WriteLine("start of coordinate system: {0}", startPoint.ToString());

            Point3D point1 = new Point3D(10, 22, 33);

            Console.WriteLine(point1.ToString());
            Console.WriteLine(Point3D.ZeroPoint.ToString());
            Console.WriteLine(new string('-', 70));
            //02. distance test
            Console.WriteLine("\ttask 2: Test distance calculation\n");

            Point3D firstPoint = new Point3D(15, 20, 22);
            Point3D secondPoint = new Point3D(10, 16, 17);

            double distance = DistanceCalculator.CalculateDistance(firstPoint, secondPoint);
            double distance2 = DistanceCalculator.CalculateDistance(firstPoint, Point3D.ZeroPoint);

            Console.WriteLine("distance between {0} and {1} is {2}", firstPoint.ToString(), secondPoint.ToString(), distance);
            Console.WriteLine("distance between {0} and {1} is {2}", firstPoint.ToString(), Point3D.ZeroPoint, distance2);
            Console.WriteLine(new string('-', 70));

            //03.Test Path storage
            Console.WriteLine("\ttask 3: Test Path storage\n");
            Path3D path = new Path3D();
            string filePath = @"..\..\points.txt";
            string safePath = @"..\..\newPoints.txt";

            Storage.LoadPathFromFile(filePath, path);
            Console.WriteLine("Path loaded from file points.txt :");
            foreach (var point in path.pointSequence)
            {
                Console.WriteLine(point);
            }
            //add more points to path
            path.pointSequence.Add(new Point3D(15, 13, 20));
            path.pointSequence.Add(new Point3D(13, 37, 55));

            Storage.SafePathToFile(safePath, path);

            Console.WriteLine("\nPath Successfully safed to file newPoints.txt :");
            foreach (var point in path.pointSequence)
            {
                Console.WriteLine(point);
            }
        }
    }
}
