// Entering a three-digit number. Displaying the last digit.
//My version.
Console.Write("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 1000 && a > 100)
//Error: оператор "<=" нельзя применить к операнду типа "bool", или "int".
{
    int d = a % 10;
    Console.WriteLine("Последний знак числа: " + d);
}
else Console.WriteLine("Это не трёхзначное число!!!");