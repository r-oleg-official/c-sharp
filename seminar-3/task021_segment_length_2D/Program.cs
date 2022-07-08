// Entering a two coordinates and calculating length of the segment between to the coordinates. 2D.

Console.WriteLine("Enter coordinates a first point: ");
int x1 = InputX(1);
int y1 = InputY(1);
Console.WriteLine("Enter coordinates a second point: ");
int x2 = InputX(2);
int y2 = InputY(2);

// Find AB. CB=x1-x2. BC=x2-x1. AC=y1-y2.
double cb = x1 - x2;
double ac = y1 - y2;
double ab = Math.Sqrt((ac * ac + cb * cb));
Console.WriteLine($"Length of segment AB={Math.Round(ab, 2)}.");

// Methods:
int InputX(int i)
    {
        Console.Write($"x{i} = : ");
        int x = Convert.ToInt32(Console.ReadLine());
        return x;
    }

int InputY(int i)
    {
        Console.Write($"y{i} = : ");
        int y = Convert.ToInt32(Console.ReadLine());
        return y;
    }