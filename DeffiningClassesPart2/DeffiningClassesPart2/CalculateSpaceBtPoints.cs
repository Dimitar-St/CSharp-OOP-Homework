namespace DeffiningClassesPart2
{
    using System;

    public static class CalculateSpaceBtPoints
    {
        public static int CalculateDistance(Point3D a, Point3D b)
        {
            int distance = (a.X - b.X) * (b.X - a.X) *
                           (a.Y - b.Y) * (b.Y - a.Y) * 
                           (a.Z - b.Z) * (b.Z - b.Z);

            return distance;
        }
    }
}

