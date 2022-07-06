// Entering a number  and displaying in degree n.
// Version by mine.
Console.Write("Введи число от 1 и более: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи степень: ");
int degreeNumber = Convert.ToInt32(Console.ReadLine());

int index = 1;
int result = number;
while (index < degreeNumber)
{
    result = result * number;
    index++;
}
Console.WriteLine($"{number}^{degreeNumber} -> {result}.");