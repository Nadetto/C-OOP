namespace DefiningClassesOne
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D() { X = 1, Y = 1, Z = 1 };
            Console.WriteLine(point.ToString());
            Console.WriteLine(Point3D.Start.ToString());

            var distance = ExtentionsPoint3D.CalculateDistnceBetween2Points(point, Point3D.Start);
            Console.WriteLine(distance);

            var sequencePoints = new Path();
            sequencePoints.AddPoint(point);

            Path path = new Path();
            string fileName = "../../path.txt";

            for (int i = 0; i < 10; i++)
			{
                path.AddPoint(new Point3D() { X = i, Y = i * 2, Z = i + 3 });
			}


            PathStorage.SavePaths(path, fileName);

            var pathFromFile = PathStorage.LoadPaths(fileName);

            foreach (var p in pathFromFile)
            {
                Console.WriteLine(p);
            }

            
        }
    }
}
