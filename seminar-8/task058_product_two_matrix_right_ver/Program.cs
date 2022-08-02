// Create two a two-demensional arrays. Calculate product both the matrixes.
// My version 2.0 (right version).

Console.Clear();
int firstRows = GetInputValue("Enter a number of rows of the first matrix: ");
int firstColumns = GetInputValue("Enter a number of columns of the first matrix: ");
Console.WriteLine();
Console.Write("The number of columns of the first matrix must be equal ");
Console.WriteLine("to the number of the rows of the second matrix!");
int secondRows = GetInputValue("Enter a number of rows of the second matrix: ");
Console.Write("The number of columns of the first matrix must be equal ");
Console.WriteLine("to the number of the rows of the second matrix!");
int secondColumns = GetInputValue("Enter a number of columns of the second matrix: ");

if (firstColumns != secondRows)
{
    Console.WriteLine("Sizes don't match of matrices!");
    return;
}

int[,] firstMatrix = new int[firstRows, firstColumns];
int[,] secondMatrix = new int[secondRows, secondColumns];
int[,] thirdMatrix = new int[firstRows, secondColumns];
int minNumber = 1,
    maxNumber = 20;

FillMatrix(firstMatrix, minNumber, maxNumber);
FillMatrix(secondMatrix, minNumber, maxNumber);
Console.WriteLine();
PrintMatrix(firstMatrix);
PrintMatrix(secondMatrix);

for (int row = 0; row < thirdMatrix.GetLength(0); row++)
{
    for (int col = 0; col < thirdMatrix.GetLength(1); col++)
    {
        thirdMatrix[row, col] = CalcProduct(firstMatrix, secondMatrix, row, col);
    }
}
PrintMatrix(thirdMatrix);

int CalcProduct(int[,] firstArray, int[,] secondArray, int row, int column)
{
    int sum = 0;
    for (int i = 0; i < firstArray.GetLength(1); i++)
    {
        sum = sum + firstArray[row, i] * secondArray[i, column];
    }
    return sum;
}

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] array, int minValue, int maxValue)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = Convert.ToInt32(new Random().Next(minValue, maxValue + 1));
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        Console.Write("|");
        for (int col = 0; col < array.GetLength(1) - 1; col++)
        {
            Console.Write($"{array[row, col]}, ");
        }
        Console.WriteLine($"{array[row, array.GetLength(1) - 1]} |");
    }
    Console.WriteLine();
}
