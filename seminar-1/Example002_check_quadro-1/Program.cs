//Enter two numbers and check if they are squares to each other.
//My version.
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 * number1 == number2)
{
    Console.WriteLine("Второе число квадрат первого.");
}
else if (number2 * number2 == number1)
{
    Console.WriteLine("Первое число квадрат второго.");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого.");
}