// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Create a two-demensional array. 

int rows = GetInputValue("Введи количество строк: ");
int columns = GetInputValue("Введи количество столбцов: ");
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintMatrix(matrix);
Console.WriteLine();

int[] varArray = new int[matrix.GetLength(1)];
for (int i = 0; i < matrix.GetLength(1); i++)
{
    varArray[i] = matrix[0, i];
}


for (int i = 0; i < varArray.GetLength(0); i++)
{
    Console.Write($"{varArray[i]} ");
}
Console.WriteLine();

int max = 0;
int tempVar = 0;
// для рокировки элементов
// int sizeRow = varArray.GetLength(0);
int sizeRow = 0;
while (sizeRow < varArray.GetLength(0))
{
    for (int j = 0; j < varArray.GetLength(0); j++)
    {
        if (max < varArray[j]) max = varArray[j];
    }
    tempVar = varArray[varArray.GetLength(0) - 1];
    varArray[0] = max;
    sizeRow++;
}

// for (int k = 0; k < sizeRow; k++)
// {
//     for (int j = 0; j < sizeRow; j++)
//     {
//         if (varArray[j] > varArray[j + 1])
//         {
//             tempVar = varArray[j];
//             varArray[j] = varArray[j + 1];
//             varArray[j + 1] = tempVar;
//         }
//     }
//     sizeRow -= 1;
// }



for (int i = 0; i < varArray.GetLength(0); i++)
{
    Console.Write($"{varArray[i]} ");
}
Console.WriteLine();


// SortElementsRows(matrix);
// PrintMatrix(matrix);


// double[] sumColumns = new double[matrix.GetLength(1)];
// CalcAverangeColumns(matrix, sumColumns);
// Console.Write("Среднее арифметическое каждого столбца: ");
// PrintAverangeColumns(sumColumns);

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

// void SortElementsRows(int[,] array)
// {
//     int min = 0; // для рокировки элементов
//     int sizeRow = array.GetLength(1); // снижается после прохода массива, сдвиг макс вправо
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sizeRow = array.GetLength(1);
//         while (sizeRow < array.GetLength(1))
//         {
//             for (int j = 0; j < sizeRow; j++)
//             {
//                 if (array[i, j] > array[i + 1, j + 1])
//                 {
//                     min = array[i + 1, j + 1];
//                     array[i + 1, j + 1] = array[i, j];
//                     array[i, j] = min;
//                     sizeRow++;
//                 }
//             }
//         }
//     }
// }

// void PrintAverangeColumns(double[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write($"{array[i]}; ");
//     }
//     Console.WriteLine($"{array[array.Length - 1]}.");
// }