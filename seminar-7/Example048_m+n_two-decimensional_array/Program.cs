// Create a two-decimensional array 'm x n', where the every elements by Aₘₙ = m+n.
// Output the array to screen.
// My version.

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] numbers = new int[m, n];
FillArray(numbers);
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
            numbers[i, j] = i + j;
        }
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}