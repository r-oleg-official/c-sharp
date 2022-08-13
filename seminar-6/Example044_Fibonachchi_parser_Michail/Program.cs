// Entering number N and displaying numbers of a Fibonachchi.
// First and second numbers of the Fibonachchi: 0 and 1.
// Version Michail with a parser. Don't right version. And I'm upgrade. 
// ??"" - use a null-coalescing operator ?? with some default value - then don't errors.

Console.Write("Введите число: ");
//string input = Console.ReadLine();
int N = int.Parse(Console.ReadLine()??"");

Console.Write("The {0} Fibonacci: ", N);

int a = 0;
int b = 1;
Console.Write(a + " ");
for (int i = 0; i < N; i++)
{
    int tempnumber = a;
    a = b;
    b = tempnumber + b;
    Console.Write($"{a} ");
}
Console.WriteLine();