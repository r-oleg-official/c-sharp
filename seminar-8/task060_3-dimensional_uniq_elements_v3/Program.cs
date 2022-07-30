// Create a three-dimensional array and filling by unique the numbers.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 1
// My version 3.0.

// // Universal code for everything a cube.
// Console.Clear();
// int rows = GetInputValue("Enter a number rows of the cube: ");
// int cols = GetInputValue("Enter a number columns of the cube: ");
// int pages = GetInputValue("Enter a number pages of the cube: ");
// int[,,] cube = new int[rows, cols, pages];
// int[] uniq = new int[cube.Length];
// int minValue = GetInputValue("Enter first number of a range: ");
// int limit = minValue + cube.Length - 2;
// int maxValue = GetInputValue($"Enter last number of a range high {limit}: ");
// if (maxValue <= limit) return;

// For the task.
Console.Clear();
int rows = GetInputValue("Enter a number rows of the cube: ");
int cols = GetInputValue("Enter a number columns of the cube: ");
int pages = GetInputValue("Enter a number pages of the cube: ");

if (rows * cols * pages > 89)
{
    pages = 89 / (rows * cols);
    Console.WriteLine();
    Console.WriteLine("The number of the pages are out from range two-digit numbers!");
}
int[,,] cube = new int[rows, cols, pages];
int[] uniq = new int[cube.Length];
int minValue = 10;
int maxValue = 99;

FillArrayUniqNumbers(uniq);
// PrintArray(uniq);
Console.WriteLine();
FillCubeUniqNumbers(cube, uniq);
PrintCubeWithIndexes(cube);
// PrintCubeNotIndexes(cube);
Console.WriteLine();
// SortCubeBubble(cube);

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

void PrintCubeWithIndexes(int[,,] cube)
{
    for (int page = 0; page < cube.GetLength(2); page++)
    {
        Console.WriteLine($"Page - {page + 1}");
        for (int row = 0; row < cube.GetLength(0); row++)
        {
            Console.Write("|");
            for (int col = 0; col < cube.GetLength(1); col++)
            {
                Console.Write($"| {cube[row, col, page]}({row},{col},{page}) |");
            }
            Console.WriteLine("|");
        }
        Console.WriteLine();
    }
}

void PrintCubeNotIndexes(int[,,] cube)
{
    for (int page = 0; page < cube.GetLength(2); page++)
    {
        Console.WriteLine($"Page-{page + 1}");
        for (int row = 0; row < cube.GetLength(0); row++)
        {
            Console.Write("|");
            for (int col = 0; col < cube.GetLength(1); col++)
            {
                Console.Write(cube[row, col, page] + " ");

            }
            Console.WriteLine("|");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArrayUniqNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        bool isUnique;
        do
        {
            // array[i] = new Random().Next(minValue, maxValue + 1);
            array[i] = GetRandomNumber(minValue, maxValue);
            isUnique = true;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    isUnique = false;
                    break;
                }
            }
        } while (!isUnique);
    }
}

void FillCubeUniqNumbers(int[,,] cube, int[] array)
{
    int indexArray = 0;
    for (int page = 0; page < cube.GetLength(2); page++)
    {
        for (int row = 0; row < cube.GetLength(0); row++)
        {
            for (int col = 0; col < cube.GetLength(1); col++)
            {
                cube[row, col, page] = array[indexArray];
                indexArray++;
            }
        }
    }
}