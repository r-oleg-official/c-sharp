// Entering random number 10-99. Displaying maximum digit of number.
// My version.
int randomNumber = new Random().Next(10, 100);
Console.WriteLine("Случайное число: " + randomNumber);
int digit1 = randomNumber / 10;
int digit2 = randomNumber % 10;

if (digit1 > digit2)
{
    Console.WriteLine("Большая цифра числа : " + digit1);
}
else
{
    Console.WriteLine("Большая цифра числа : " + digit2);
}