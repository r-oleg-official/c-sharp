// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int rows = EnterSizeArray("Введи количество строк: ");
int columns = EnterSizeArray("Введи количество столбцов: ");
int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintMatrix(matrix);
double[] sumColumns = new double[matrix.GetLength(1)];
CalcAverangeColumns(matrix, sumColumns);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintAverangeColumns(sumColumns);

int EnterSizeArray(string msg)
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

void CalcAverangeColumns(int[,] array, double[] arraySums)
{
    double sumColumn = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sumColumn = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumColumn += Convert.ToDouble(array[j, i]);
        }
        arraySums[i] = Math.Round((sumColumn / array.GetLength(0)), 1);
    }
}

void PrintAverangeColumns(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.WriteLine($"{array[array.Length - 1]}.");
}