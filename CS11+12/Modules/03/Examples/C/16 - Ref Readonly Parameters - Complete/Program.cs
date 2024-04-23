using Wincubate.CS12.Slide16;
using static System.Math;

Point3D p1 = new() { X = -1, Y = 0, Z = -1 };
Point3D p2 = new() { X = 1, Y = 2, Z = 3 };

Console.WriteLine(
    $"""
    The distance between {p1} and {p2} is {
        CalculateDistance(ref p1, p2)
    };
    """);


static double CalculateDistance(ref readonly Point3D first, in Point3D second = default)
{
    double xDiff = first.X - second.X;
    double yDiff = first.Y - second.Y;
    double zDiff = first.Z - second.Z;

    // first.Z = 666;

    return Sqrt(xDiff * xDiff + yDiff * yDiff + zDiff * zDiff);
}
