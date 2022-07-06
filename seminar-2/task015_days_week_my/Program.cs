// Enter number a day of the week and displaying only a weekend? Yes, or no.
// Version by mine.
Console.Write("Введите день недели цифрой от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 ^ number > 7)
{
    Console.WriteLine("Неверно! Нужно вводить от 1-7.");
}
else if (number > 5 & number < 8)
{
    Console.WriteLine(" -> да.");
}
else
{
    Console.WriteLine(" -> нет.");
}