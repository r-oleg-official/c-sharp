// Create a rectangular two-demencial array.
// Find a row with lossest summ of the elements to row and displaying the number of this row.
// My version.
Console.Clear();
int rows = GetInputValue("Enter a number of rows: ");
int columns = GetInputValue("Enter a number of columns: ");
int[,] matrix = new int[rows, columns];
int[] summRows = new int[rows];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
CalcSumRowToArray(matrix, summRows);

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = Convert.ToInt32(new Random().Next(0, 10));
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col]} ");
        }
        Console.WriteLine();
    }
}

void CalcSumRowToArray(int[,] sArray, int[] resArray)
{
    for (int row = 0; row < sArray.GetLength(0); row++)
    {
        int sum = 0;
        for (int col = 0; col < sArray.GetLength(1); col++)
        {
            sum = sum + sArray[row, col];
        }
        resArray[row] = sum;
    }
    int min = resArray[0];
    int min_row = 1;
    int i = 1;
    while (i < resArray.Length)
    {
        if (resArray[i] < min)
        {
            min = resArray[i];
            min_row = i + 1;
        }
        i++;
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке № {min_row}");
}