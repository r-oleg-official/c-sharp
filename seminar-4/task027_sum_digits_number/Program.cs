// Entering number and displaying a sum digits of the number.
int number = InputNumber("Enter a number: ");

int result = 0;
while (number > 0)
{
    result = result + number % 10;
    number = number / 10;
}

Console.WriteLine($" -> {result}.");

int InputNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}