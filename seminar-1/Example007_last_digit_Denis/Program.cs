//Entering a three-digit number. Displaying the last digit.
// Version by Denis.
Console.Write("Введите трёхзначое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    if (number < 1000)
    {
        int result = number % 10;
        Console.WriteLine(result);
    }
}