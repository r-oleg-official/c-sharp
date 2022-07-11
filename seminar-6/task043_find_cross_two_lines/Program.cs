// Have a two equations: y = k1 * x + b1, y = k2 * x + b2. User will be entering: b1, k1, b2 and k2.
// You are need find a point of cross a two lines.
// My version.

double b1 = InputFactor("Enter b1: ");
double k1 = InputFactor("Enter k1: ");
double b2 = InputFactor("Enter b2: ");
double k2 = InputFactor("Enter k2: ");

double x = (b2-b1) / (k1 -k2);
double y = k2 * x + b2;

Console.WriteLine($" -> ({x};{y}).");

double InputFactor(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}