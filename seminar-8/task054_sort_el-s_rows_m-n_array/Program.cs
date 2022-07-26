// Create a two-demensional array. Sort the elements of each a row in descending order.
// My version.
Console.Clear();
int rows = GetInputValue("Enter a number of rows: ");
int columns = GetInputValue("Enter a number of columns: ");
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintMatrix(matrix);
Console.WriteLine();

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int k = 0; k < matrix.GetLength(1) - 1; k++)
    {
        bool stopSort = true;
        int swap = 0;
        for (int col = 0; col < matrix.GetLength(1) - 1 - k; col++)
        {
            if (matrix[row, col] < matrix[row, col + 1])
            {
                swap = matrix[row, col + 1];
                matrix[row, col + 1] = matrix[row, col];
                matrix[row, col] = swap;
                stopSort = false;
            }
        }
        if (stopSort == true) break;
    }
}

PrintMatrix(matrix);

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
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