namespace Wincubate.CS12.Slide16;

struct Point3D(double x, double y, double z)
{
    public double X { get; set; } = x;
    public double Y { get; set; } = y;
    public double Z { get; set; } = z;

    public override readonly string ToString() => $"({X},{Y},{Z})";
}
