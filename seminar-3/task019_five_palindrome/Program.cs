// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Entering a five-digit number and check it's a palindrome?
// My simple version.

Console.Write("Enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 && number > 9999)
{
    Console.WriteLine("Error! Need enter a five-digit number: ");
}
else if ( number > 9999 && number < 100000)
    {
        // Stage-1: get first and last digit of the number
        int count = 10;
        int max_count = 10000;
        int digit1 = number / max_count;
        int digit2 = number % count;
        
        // Stage-2: cut begin and end of number.
        number = number % max_count;
        number = number / count;
        max_count = 100;
        
        // Stage-3: get first and last digit of the number
        int digit3 = number / max_count;
        int digit4 = number % count;
        
        // Stage-4: digits are matching?
        if (digit1 == digit2 && digit3 == digit4)
        {
            Console.WriteLine("It's palindrome!");
        }
        else
        {
            Console.WriteLine("It's not palindrome!");
        }
    }