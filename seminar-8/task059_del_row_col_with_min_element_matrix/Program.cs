/*
Create a matrix and filling by the numbers, example, the random numbers.
Delete are row and column on the cross with a minimal element to the matrix.
My version 1.0.
*/
Console.Clear();
int rows = GetInputValue("Enter a number of rows of the matrix: ");
int columns = GetInputValue("Enter a number of columns of the matrix: ");
// int minNumber = GetInputValue("Enter a minimal number to the matrix: ");
// int maxNumber = GetInputValue("Enter a maximal number to the matrix: ");
int[,] matrix = new int[rows, columns];
int minNumber = 5;
int maxNumber = 80;

FillMatrix(matrix, minNumber, maxNumber);
PrintMatrix(matrix);

string minElement = FindMinElementMatrix(matrix);
int rowMinElement = Convert.ToInt32(minElement).Parse(",");
// int colMinElement = ConvertminElement.Parse(",");
Console.WriteLine($"{rowMinElement}");


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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine($"{array[i, array.GetLength(1) - 1]} |");
    }
}

string FindMinElementMatrix(int[,] array)
{
    int min = array[0, 0];
    string position = String.Empty;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (array[row, col] < min) 
            {
                min = array[row, col];
                position = row + "," + col;
            }
        }
    }
    return position;
}
