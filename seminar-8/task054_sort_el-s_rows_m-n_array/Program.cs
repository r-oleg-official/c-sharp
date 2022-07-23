// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Create a two-demensional array. 
// My version.

int rows = GetInputValue("Введи количество строк: ");
int columns = GetInputValue("Введи количество столбцов: ");
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintMatrix(matrix);
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int k = 0; k < matrix.GetLength(1) - 1; k++)
    {
        bool stopSort = true;
        int box = 0;
        for (int j = 0; j < matrix.GetLength(1) - 1 - k; j++)
        {
            if (matrix[i,j] < matrix[i, j + 1])
            {
                box = matrix[i, j + 1];
                matrix[i, j + 1] = matrix[i,j];
                matrix[i,j] = box;
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