using Wincubate.CS12.Slide16;
using static System.Math;

Point3D p1 = new() { X = -1, Y = 0, Z = -1 };
Point3D p2 = new() { X = 1, Y = 2, Z = 3 };

Console.WriteLine($"The distance between {p1} and {p2} is {CalculateDistance(p1, p2)}");


static double CalculateDistance(Point3D first, Point3D second)
{
    double xDiff = first.X - second.X;
    double yDiff = first.Y - second.Y;
    double zDiff = first.Z - second.Z;

    return Sqrt(xDiff * xDiff + yDiff * yDiff + zDiff * zDiff);
}
