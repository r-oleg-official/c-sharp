// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Entering a five-digit number and check it's a palindrome?

Console.Write("Введи пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 10;
int max_count = 10000;
bool tumbler1 = Palindrome(number, max_count, count);

Console.WriteLine($"{number}, {max_count}, {count}");
Console.WriteLine(tumbler1);

max_count = 100;
number = CutNumber(number, max_count, count);
Console.WriteLine($"{number}, {max_count}, {count}");

bool tumbler2 = Palindrome(number, max_count, count);
Console.WriteLine(tumbler2);
if (tumbler1 == tumbler2)
{
    Console.WriteLine("It's palindrome!");
}
else
{
    Console.WriteLine("It's not palindrome!");
}
// Функции:
bool Palindrome(int number, int max_count, int count)
{
    int digit1 = number / max_count;
    int digit2 = number % count;
    if (digit1 == digit2) 
        {
            return true;
        }
    else
        {
            return false;
        }
}
int CutNumber(int number, int max_count, int count)
{
    number = number % max_count;
    number = number / count;
    return number;
}
