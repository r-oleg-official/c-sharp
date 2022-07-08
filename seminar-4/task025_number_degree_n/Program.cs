// Entering a number  and displaying in degree n.
// Version by mine.
Console.Write("Введи число A от 1 и более: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число В - степень числа: ");
int degreeNumber = Convert.ToInt32(Console.ReadLine());

int index = 1;
int result = number;
while (index < degreeNumber)
{
    result = result * number;
    index++;
}
Console.WriteLine($"{number}^{degreeNumber} -> {result}.");