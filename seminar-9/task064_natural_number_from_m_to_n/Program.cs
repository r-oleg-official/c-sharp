/* 
Input M, N and displaying everything a natural numbers in range from M to N.
My version.
*/

int m = GetInputValue("Enter a first number: ");
int n = GetInputValue("Enter a second number: ");
Console.Clear();
Console.Write($"M = {m}; N = {n}. -> \"\"");
Console.Write(NaturalNumber(m, n));
Console.WriteLine("\"\"");
Console.WriteLine();

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int NaturalNumber(int firstNumber, int secondNumber)
{
    if (secondNumber == firstNumber) return firstNumber;
    else
        Console.Write(NaturalNumber(firstNumber, secondNumber - 1) + ", ");
    return secondNumber;
}
