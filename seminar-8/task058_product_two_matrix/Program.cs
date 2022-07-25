// Create two a two-demensional arrays. Calculate product of these matrixs.
// My version.
int firstRows = GetInputValue("Enter how much rows of the first matrix: ");
int firstColumns = GetInputValue("Enter how much columns of the first matrix: ");
int secondRows = GetInputValue("Enter how much rows of the second matrix: ");
int secondColumns = GetInputValue("Enter how much columns of the second matrix: ");
int[,] firstMatrix = new int[firstRows, firstColumns];
int[,] secondMatrix = new int[secondRows, secondColumns];
int[,] thirdMatrix = new int[secondRows, secondColumns];

Console.WriteLine($"{firstMatrix.Length}, {secondMatrix.Length}");

if (firstMatrix.Length != secondMatrix.Length)
{
    Console.WriteLine("Sizes don't match of matrixes!");

}
else if (firstMatrix.Length == secondMatrix.Length)
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

void ProductTwoMatrixs(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    // if (firstArray.GetLength != secondArray.GetLength)
    // {
    //     Console.WriteLine("Sizes don't match of matrixes!");
    //     return;
    // }
    // else if (firstArray.GetLength == secondArray.GetLength)
    // {
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            resultArray[i, j] = firstArray[i, j] * secondArray[i, j];
        }
    }
    // }
    // return resultArray;
}