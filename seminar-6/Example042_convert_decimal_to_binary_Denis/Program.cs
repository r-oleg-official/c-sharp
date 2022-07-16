// Convert decimal number to binary number.
// Version Denis.
int number = InputInt("Введите число: ");
string result = string.Empty;
while(number > 0)
{
  result = number % 2 + result;
  number /= 2;
}
Console.WriteLine(result);

int InputInt(string str)
{
  Console.Write(str);
  return Convert.ToInt32(Console.ReadLine());
}