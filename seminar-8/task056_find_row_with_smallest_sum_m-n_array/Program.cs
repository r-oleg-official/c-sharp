// Create a rectangular two-demencial array.
// Find a row with lossest summ of the elements to row and displaying the number of this row.
// My version.
Console.Clear();
int rows = GetInputValue("Enter a number of rows: ");
int columns = GetInputValue("Enter a number of columns: ");
int[,] matrix = new int[rows, columns];
// int[] summRows = new int[rows];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

int min_row = CalcSumRow(matrix);
Console.WriteLine($"Наименьшая сумма элементов в строке № {min_row}");

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int CalcSumRow(int[,] sArray)
{
    int min_index = 1;
    int check = 0;
    int sum = 0;
    for (int i = 0; i < sArray.GetLength(0); i++)
    {
        // int check = 0;
        sum = 0;
        for (int j = 0; j < sArray.GetLength(1); j++)
        {
            sum += sArray[i, j];
        }
        if (sum < check)
        {
            check = sum;
            min_index++;
        }
    }
    return min_index;
}