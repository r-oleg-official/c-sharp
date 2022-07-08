// Entering a two coordinates and calculating length of the segment between to the coordinates. 3D.
// My version.
string x = "x", y = "y", z = "z";
Console.WriteLine("Enter coordinates a first point: ");
int x1 = InputCoordinate(x, 1);
int y1 = InputCoordinate(y, 1);
int z1 = InputCoordinate(z, 1);
Console.WriteLine("Enter coordinates a second point: ");
int x2 = InputCoordinate(x, 2);
int y2 = InputCoordinate(y, 2);
int z2 = InputCoordinate(z, 2);

// Find AB. AB^2 = (xb -xa)^2 + (yb -ya)^2 + (zb -za)^2.
double xx = x2 - x1;
double yy = y2 - y1;
double zz = z2 - z1;
double ab = Math.Sqrt((xx * xx + yy * yy + zz * zz));

Console.WriteLine($"Length of segment AB={Math.Round(ab, 2)}.");

// Methods:
int InputCoordinate(string point, int i)
    {
        Console.Write($"{point}{i}= ");
        int x = Convert.ToInt32(Console.ReadLine());
        return x;
    }