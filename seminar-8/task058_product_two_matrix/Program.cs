// Create two a two-demensional arrays. Calculate product both the matrixes.
// My version.
Console.Clear();
int firstRows = GetInputValue("Enter how much rows of the first matrix: ");
int firstColumns = GetInputValue("Enter how much columns of the first matrix: ");
int secondRows = GetInputValue("Enter how much rows of the second matrix: ");
int secondColumns = GetInputValue("Enter how much columns of the second matrix: ");
int[,] firstMatrix = new int[firstRows, firstColumns];
int[,] secondMatrix = new int[secondRows, secondColumns];
int[,] thirdMatrix = new int[secondRows, secondColumns];

if (firstMatrix.Length != secondMatrix.Length)
{
    Console.WriteLine("Sizes don't match of matrices!");
    return;
}
if (firstMatrix.Length == secondMatrix.Length)
{
    FillArray(firstMatrix);
    FillArray(secondMatrix);
    PrintMatrix(firstMatrix);
    Console.WriteLine();
    PrintMatrix(secondMatrix);
    Console.WriteLine();

    ProductTwoMatrixs(firstMatrix, secondMatrix, thirdMatrix);
    PrintMatrix(thirdMatrix);
}

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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ProductTwoMatrixs(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int row = 0; row < firstArray.GetLength(0); row++)
    {
        for (int col = 0; col < firstArray.GetLength(1); col++)
        {
            resultArray[row, col] = firstArray[row, col] * secondArray[row, col];
        }
    }
}