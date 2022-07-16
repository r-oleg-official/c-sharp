// User is entering array of a numbers. Need calculate sum of the positive numbers. 
// Version by Denis.
Console.WriteLine("Введите числа через запятую: ");
string numberString = Console.ReadLine();

int[] array = ParseArray(numberString, ',');
PrintArray(array);

int[] ParseArray(string input, char separator)
{
    int[] numbers = new int[GetCountNumbersInString(input)];
    string subString = String.Empty;
    int numbersIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if(input[i] == separator)
        {
            numbers[numbersIndex++] = Convert.ToInt32(subString);
            subString = string.Empty;
        }
        else
        {
            subString += input[i];
        }
    }
    numbers[numbersIndex] = Convert.ToInt32(subString);
    return numbers;
}

int GetCountNumbersInString(string numbers)
{
    int countNumbers = 1;
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] == ',')
            countNumbers++;
    }
    return countNumbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}