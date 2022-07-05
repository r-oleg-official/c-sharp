//Enter two numbers and check if they are squares to each other.
//If first number don't quadro the second number to displaying 
//the remainder to the division.
//My version.
Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine("Кратно.");
}
else if (number2 == 0)
{
    Console.WriteLine("Нельзя делить на нуль!");
}
else if (number1 != number2 * number2)
{
    int remain = number1 % number2;
    Console.WriteLine("Не кратно, " + remain);
}