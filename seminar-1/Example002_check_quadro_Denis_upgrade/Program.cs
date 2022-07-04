// Upgrade code by Denis.
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || b * b == a)
{
    Console.WriteLine("ДА");
}
else if (a * a != b || b * b != a)
{
    Console.WriteLine("НЕТ");
}