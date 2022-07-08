// Entering a five-digit number and check - it's a palindrome?

Console.Write("Enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    int count = 10;
    int max_count = 10000;
    int cutter = 100; // scissors for extreme numbers.

    // Stage-1: check first and last digits is matching?
    bool tumbler1 = Palindrome(number, max_count, count);

    // Stage-2: cut first and last digits.
    number = CutNumber(number, max_count, count);
    max_count = max_count / cutter;

    // Stage-3: check first and last digits is matching?
    bool tumbler2 = Palindrome(number, max_count, count);
    
    // Output result
    if (tumbler1 == true && tumbler2 == true)
    {
        Console.WriteLine("It's palindrome!");
    }
    else
    {
        Console.WriteLine("It's not palindrome!");
    }
    // Functions:
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
}
else 
{
    Console.WriteLine("Error! Need entering a five-digit number");
}