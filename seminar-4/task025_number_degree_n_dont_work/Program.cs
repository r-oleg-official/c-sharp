// Entering a number  and displaying in degree n.
// Version by mine.
//Don't work!
Console.Write("Введи число от 1 и более: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи степень: ");
int degreeNumber = Convert.ToInt32(Console.ReadLine());
Console.Write(number);
int index = 1;
//int result = number;
while (index < degreeNumber)
{
    number = number * number;
    index++;
}
Console.WriteLine($"^{degreeNumber} -> {number}.");