namespace DefiningClassesOne
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Path : IEnumerable<Point3D>
    {
        private ICollection<Point3D> pointSequence;

        public Path()
        {
            this.pointSequence = new List<Point3D>();
        }

        public ICollection<Point3D> PointSequence { get; set; }

        public void AddPoint(Point3D point)
        {
            this.pointSequence.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.pointSequence.Remove(point);
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            return this.pointSequence.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
