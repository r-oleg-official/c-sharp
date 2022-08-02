/* Create a two-demensional array 4x4 and him filling to spiral.
My version 1.0. Work with a square matrix. Other will be errors.
*/
Console.Clear();
// int rows = GetInputValue("Enter a number of rows of the matrix: ");
// int columns = GetInputValue("Enter a number of columns of the matrix: ");
// int fill = GetInputValue("Enter a begin number for filling of the matrix: ");
// int[,] spiral = new int[rows, columns];
int[,] spiral = new int[4, 4];

int i = 0,
    fill = 1,                       // A number for filling.
    startRow = 0,
    startCol = 0,
    endCount = spiral.Length,
    lastRow = spiral.GetLength(0),
    lastCol = spiral.GetLength(1);

while (i <= endCount)
{
    startRow = FillRight(spiral, fill, startRow, startCol, lastRow, lastCol);
    lastCol = FillDown(spiral, fill, startRow, startCol, lastRow, lastCol);
    lastRow = FillLeft(spiral, fill, startRow, startCol, lastRow, lastCol);
    startCol = FillUp(spiral, fill, startRow, startCol, lastRow, lastCol);
    i++;
}

PrintMatrix(spiral);

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int FillRight(int[,] matrix, int number, int sRow, int sCol, int lRow, int lCol)
{
    for (int j = sCol; j < lCol; j++)
    {
        matrix[sRow, j] = fill;
        fill++;
    }
    return sRow + 1;
}
int FillDown(int[,] matrix, int number, int sRow, int sCol, int lRow, int lCol)
{
    for (int i = sRow; i < lRow; i++)
    {
        matrix[i, lCol - 1] = fill;
        fill++;
    }
    return lCol - 1;
}
int FillLeft(int[,] matrix, int number, int sRow, int sCol, int lRow, int lCol)
{
    for (int j = lCol - 1; j > sCol - 1; j--)
    {
        matrix[lRow - 1, j] = fill;
        fill++;
    }
    return lRow - 1;
}
int FillUp(int[,] matrix, int number, int sRow, int sCol, int lRow, int lCol)
{
    for (int i = lCol - 1; i > sCol; i--)
    {
        matrix[i, sCol] = fill;
        fill++;
    }
    return sCol + 1;
}

void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        Console.Write("|");
        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
        {
            Console.Write($"{matrix[row, col]}, ");
        }
        Console.WriteLine($"{matrix[row, matrix.GetLength(1) - 1]} |");
    }
}

/* 
Begin status of the matrix.
Calc the center of the array.
Examples:
1. a square array;
2. don't square array;
3. size%2 = 0;
4. size%2 = 1;

A Private event 3x3.
indexRow = array.GetLength(0) / 2; // =1;
indexCol = array.GetLength(1) / 2; // =1;

Array is filling while array[i,j] = 0.
if (Array[i, j] == 0) fill;
*/