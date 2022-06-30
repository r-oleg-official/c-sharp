Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

// First method write variables
// установить вершину 'a'
// int xa = 1; // x-координата 'a' 
// int ya = 1; // y-координата 'a'
// установить вершину 'b'
// int xb = 1;
// int yb = 30;

// Second method write variables
// int xa = 1, ya = 1, xb = 1, yb = 30;

//Third method write variables
int xa = 40, ya = 1, 
    xb = 1, yb = 30,
    xc = 80, yc = 30;

// Нарисовать точки вершин треугольника
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.Write("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

// Выбор случайной точки, например, 
int x = xa, y = xb;

