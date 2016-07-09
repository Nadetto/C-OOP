namespace DefiningClassesOne
{
    using System;
    using System.Collections.Generic;
    using System.IO;
   
    public static class PathStorage
    {
        public static void SavePaths(Path path, string filePath)
        {
            var sw = new StreamWriter(filePath);
            using(sw)
            {
                foreach (var point in path)
                {
                    sw.WriteLine(point);
                }
            }
        }

        public static Path LoadPaths(string filePath)
        {
            var path = new Path();
            var sr = new StreamReader(filePath);
            using(sr)
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var point = Point3D.Parse(line);
                    path.AddPoint(point);                    
                }
            }

            return path;
        }

    }
}
