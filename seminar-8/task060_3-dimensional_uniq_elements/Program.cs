﻿// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 1
// My version. Don't work.

Console.Clear();
int rows = GetInputValue("Enter a number rows of the cube: ");
int cols = GetInputValue("Enter a number columns of the cube: ");
int pages = GetInputValue("Enter a number pages of the cube: ");
// int minValue = GetInputValue("Enter first number of a range: ");
// int maxValue = GetInputValue("Enter last number of a range: ");
int minValue = 10;
int maxValue = 99;
int[,,] cube = new int[rows, cols, pages];

FillCubeUniqNumbers(cube, minValue, maxValue);
// PrintCubeWithIndexes(cube);
PrintCubeNotIndexes(cube);
Console.WriteLine();
SortCubeBubble(cube);
// PrintCubeWithIndexes(cube);
PrintCubeNotIndexes(cube);

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// void PrintCubeWithIndexes(int[,,] cube)
// {
//     for (int page = 0; page < cube.GetLength(2); page++)
//     {
//         Console.WriteLine($"Page - {page + 1}");
//         for (int row = 0; row < cube.GetLength(0); row++)
//         {
//             // Console.WriteLine("---------");
//             Console.Write("|");
//             for (int col = 0; col < cube.GetLength(1); col++)
//             {
//                 // Console.Write($"| {row},{col},{page} |");
//                 Console.Write($"| {cube[row, col, page]}({row},{col},{page}) |");
//             }
//             // Console.Write("----------------");
//             Console.WriteLine("|");
//             // Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

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
    }
}


void FillCubeUniqNumbers(int[,,] cube, int minValue, int maxValue)
{
    for (int page = 0; page < cube.GetLength(2); page++)
    {
        for (int row = 0; row < cube.GetLength(0); row++)
        {
            for (int col = 0; col < cube.GetLength(1); col++)
            {
                bool isUnique;
                do
                {
                    cube[row, col, page] = new Random().Next(minValue, maxValue);
                    isUnique = true;
                    for (int i = 0; i < page; i++)
                    {
                        for (int j = 0; j < row; j++)
                        {
                            for (int k = 0; k < col; k++)
                            {
                                if (cube[row, col, page] == cube[j, k, i])
                                {
                                    isUnique = false;
                                    return;
                                }
                            }
                        }
                    }
                }
                while (!isUnique);
            }
        }
    }
}

void SortCubeBubble(int[,,] cube)
{
    // int var = cube[0, 0, 0];
    int var = 0;
    bool isSort = false;
    for (int k = 0; k < cube.Length; k++)
    {
        for (int page = 0; page < cube.GetLength(2); page++)
        {
            for (int row = 0; row < cube.GetLength(0); row++)
            {
                for (int col = 0; col < cube.GetLength(1) - 1; col++)
                {
                    if (cube[row, col, page] > cube[row, col + 1, page])
                    {
                        var = cube[row, col + 1, page];
                        cube[row, col + 1, page] = cube[row, col, page];
                        cube[row, col, page] = var;
                    }
                }
            }
            isSort = true;
        }
        if (isSort == false) break;
    }
}


// I'am try create a recursive function for filling the cube by unique numbers.
// void FillArrayUniqNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int element = new Random().Next(10, 100);
//         if (FindElement(array, element) == false) array[i] = element;
//     }
// }
// bool FindElement(int[] uniq, int element)
// {
//     // int element = uniq[0];
//     bool check = false;
//     for (int i = 0; i < uniq.Length; i++)
//     {
//         if (element == uniq[i]) check = true;
//     }
//     return check;
// }
