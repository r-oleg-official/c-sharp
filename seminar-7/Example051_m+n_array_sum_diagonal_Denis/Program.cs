// Create a two-demesional array. 
// Calculate score of elements in diagonal the array.
// Result: Сумма элементов главной диагонали: 1+9+2 = 12
// Version by Denis.

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillArray(numbers);
PrintArray(numbers);

for(int i = 1; i < numbers.GetLength(0); i+=2)
{
    for(int j = 1; j < numbers.GetLength(1); j+=2)
    {
        numbers[i, j] *= numbers[i, j];
    }
}
Console.WriteLine();
PrintArray(numbers);

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

void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 10);
        }
    }
}

int ReadInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}