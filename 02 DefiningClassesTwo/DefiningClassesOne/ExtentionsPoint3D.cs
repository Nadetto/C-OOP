namespace DefiningClassesOne
{
    using System;
    
    public static class ExtentionsPoint3D
    {
        public static double CalculateDistnceBetween2Points(Point3D point1, Point3D point2)
        {
            double distance = 0.0;
            distance = Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X) +
                (point1.Y - point2.Y) * (point1.Y - point2.Y) +
                (point1.Z - point2.Z) * (point1.Z - point2.Z));

            return distance;
        }
    }
    
}
