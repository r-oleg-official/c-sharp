// Find a element into two-demensional array by entering of position, example 'mn',
// where m - a number of row and n - a number of column. Enter no more than 9 numbers.
// Example: 17 -> такого числа в массиве нет.
// My version.

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
Console.Write("Введите номер позиции элемента массива: ");
int positionNumber = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m, n];

FillArray(numbers);
PrintArray(numbers);
string result = FindElementArray(numbers, positionNumber);

Console.WriteLine($"{positionNumber}{result}");

string FindElementArray(int[,] array, int positionElement)
{
    int m = positionElement / 10;
    int n = positionElement % 10;
    string result = String.Empty;
    if(m < array.GetLength(0) && n < array.GetLength(1))
    {
        result = " -> " + array[m,n];
    }
    else result = " -> такого элемента не найдено.";
    return result;
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}