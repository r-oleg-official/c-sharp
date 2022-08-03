/*
Create a matrix and filling by the numbers, example, the random numbers.
Delete are row and column on the cross with a minimal element to the matrix.
My version 1.0.
*/
Console.Clear();
int rows = GetInputValue("Enter a number of rows of the matrix: "),
    columns = GetInputValue("Enter a number of columns of the matrix: ");
// int minFillNumber = GetInputValue("Enter a minimal number to the matrix: ");
// int maxFillNumber = GetInputValue("Enter a maximal number to the matrix: ");
int[,] beginMatrix = new int[rows, columns];
int minFillNumber = 5,
    maxFillNumber = 80;

FillMatrix(beginMatrix, minFillNumber, maxFillNumber);
PrintMatrix(beginMatrix);
Console.WriteLine();

int min = beginMatrix[0, 0],
// int min = 0,
    indexRowMinElement = 0,
    indexColumnMinElement = 0;
for (int row = 0; row < beginMatrix.GetLength(0); row++)
{
    for (int col = 0; col < beginMatrix.GetLength(1); col++)
    {
        if (beginMatrix[row, col] < min)
        {
            min = beginMatrix[row, col];
            indexRowMinElement = row;
            indexColumnMinElement = col;
        }
    }
}

int[,] endMatrix = new int[beginMatrix.GetLength(0) - 1, beginMatrix.GetLength(1) - 1];
RemoveRowColumnInCrossElement(beginMatrix, endMatrix, indexRowMinElement, indexColumnMinElement);
PrintMatrix(endMatrix);

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] array, int minValue, int MaxValue)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = Convert.ToInt32(new Random().Next(minValue, MaxValue + 1));
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        Console.Write("| ");
        for (int col = 0; col < array.GetLength(1) - 1; col++)
        {
            Console.Write($"{array[row, col]}, ");
        }
        Console.WriteLine($"{array[row, array.GetLength(1) - 1]} |");
    }
}

void RemoveRowColumnInCrossElement(int[,] arraySource, int[,] arrayResult, int indexRow, int indexColumn)
{
    int rowResult = 0,
        colResult = 0;
    for (int row = 0; row < arraySource.GetLength(0); row++)
    {
        if (row != indexRow)
        {
            for (int col = 0; col < arraySource.GetLength(1); col++)
            {
                if (col != indexColumn)
                {
                    arrayResult[rowResult, colResult] = arraySource[row, col];
                    colResult++;
                }
            }
            rowResult++;
        }
        colResult = 0;
    }
}