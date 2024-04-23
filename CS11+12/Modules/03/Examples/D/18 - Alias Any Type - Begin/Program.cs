using C = System.Console;

var v1 = (1, 2, 3);
var v2 = (4, 5, 6);
C.WriteLine(AddVectors(v1, v2));

(double x, double y, double z) AddVectors(
    (double x, double y, double z) first,
    (double x, double y, double z) second
) =>
    (first.x + second.x, first.y + second.y, first.z + second.z);

