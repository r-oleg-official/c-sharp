// Enter a three-digit number and display the second digit of the number.
// My version.
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit2 = number % 100;

if (number > 99 & number < 1000)
{
    digit2 = digit2 / 10;
    Console.WriteLine($"Вторая цифра числа: {digit2}.");
}
else
{
     Console.WriteLine("Неверно! Нужно вводить трёхзначное число.");
}