// Convert decimal number to binary number. Recursive method.
// Recursive: 01:04:57.
// Version Denis.
int number = InputInt("Введите число: ");
ToBin(number);
Console.WriteLine();

void ToBin(int number)
{
    if (number == 0)
    {
        return;
    }
    Console.Write(number % 2);
    ToBin(number / 2);
}

int InputInt(string output)
{
  Console.Write(output);
  return Convert.ToInt32(Console.ReadLine());
}