// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка
// My version.
Console.Clear();
int rows = GetInputValue("Введи количество строк: ");
int columns = GetInputValue("Введи количество столбцов: ");
int[,] matrix = new int[rows, columns];
// int[] summRows = new int[rows];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

int min_row = CalcSumRow(matrix) + 1;
Console.WriteLine($"Наименьшая сумма элементов в строке № {min_row}");

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] array)
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

int CalcSumRow(int[,] sArray)
{
    int min_index = 0;
    //     check = 0,
    //     sum = 0;
    for (int i = 0; i < sArray.GetLength(0); i++)
    {
        int check = 0,
            sum = 0;
        // check = 0;
        // sum = 0;
        if (sum < check) 
        {
            check = sum;
            min_index = i;
        }
        else
        for (int j = 0; j < sArray.GetLength(1); j++)
        {
            sum += sArray[i,j];
        }
    }
    return min_index;
}