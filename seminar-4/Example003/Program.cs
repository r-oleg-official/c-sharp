// Factorial of number.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = 1;

for (int count = 1; count <= number; count++)
{
    factorial = factorial * count;
}
Console.WriteLine("Факториал числа " + number + ": " + factorial + ".");