// Entering a two coordinates and calculating length of the segment between to the coordinates. 3D.
// My version.

Console.WriteLine("Enter coordinates a first point: ");
int x1 = InputCoordinate(x, 1);
int y1 = InputCoordinate(y, 1);
int z1 = InputCoordinate(z, 1);
Console.WriteLine("Enter coordinates a second point: ");
int x2 = InputCoordinate(x, 2);
int y2 = InputCoordinate(y, 2);
int z2 = InputCoordinate(z, 2);

// Find AB. CB=x1-x2. BC=x2-x1. AC=y1-y2.
//double cb = x1 - x2;
//double ac = y1 - y2;
//double ab = Math.Sqrt((ac * ac + cb * cb));

// Find AB. CB=x1-x2. BC=x2-x1. AC=y1-y2.

Console.WriteLine($"Length of segment AB={Math.Round(ab, 2)}.");

// Methods:
int InputCoordinate(string point, int i)
    {
        Console.Write($"{point}{i} = : ");
        int x = Convert.ToInt32(Console.ReadLine());
        return x;
    }

//int InputY(int i)
//    {
//        Console.Write($"y{i} = : ");
//        int y = Convert.ToInt32(Console.ReadLine());
//        return y;
//    }