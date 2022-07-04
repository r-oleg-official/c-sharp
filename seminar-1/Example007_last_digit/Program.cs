// Entering a three-digit number. Displaying the last digit.
//My version.
Console.Write("Введите трёхзначное целое число: ");
int lastDigit = Convert.ToInt32(Console.ReadLine());
if (lastDigit < 100 | lastDigit > 999)
{
    Console.WriteLine("Ввели неверное число.");
}
else
{
    lastDigit = lastDigit % 10;
    Console.WriteLine("Последняя цифра числа: " + lastDigit + ".");
}