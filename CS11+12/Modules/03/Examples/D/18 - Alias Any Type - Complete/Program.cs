global using Vector3D = (double x, double y, double z);
using C = System.Console;
using MaybeVector3D = (double x, double y, double z)?;
//using MyString = string?;

var v1 = (1, 2, 3);
var v2 = (4, 5, 6);
C.WriteLine(AddVectors(v1, v2));

static Vector3D AddVectors(Vector3D first, MaybeVector3D second) =>
    (first.x + second?.x ?? 0,
     first.y + second?.y ?? 0, 
     first.z + second?.z ?? 0);

