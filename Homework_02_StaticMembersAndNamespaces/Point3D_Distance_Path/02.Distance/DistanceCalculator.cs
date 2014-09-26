namespace Point3dDistancePath._02.Distance
{
    using System;
    using Point3dDistancePath._01._3DPoint;

    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt((firstPoint.X * firstPoint.X - secondPoint.X * secondPoint.X) +
                                       (firstPoint.Y * firstPoint.Y - secondPoint.Y * secondPoint.Y) +
                                       (firstPoint.Z * firstPoint.Z - secondPoint.Z * secondPoint.Z));
            return distance;
        }
    }
}
