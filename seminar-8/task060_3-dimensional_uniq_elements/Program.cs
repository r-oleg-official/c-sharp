
Console.Clear();
int rows = GetInputValue("Enter a number rows of the cube: ");
int cols = GetInputValue("Enter a number columns of the cube: ");
int pages = GetInputValue("Enter a number pages of the cube: ");
int[,,] cube = new int[rows, cols, pages];
// int sizeUniqArray = cube.Length;
int[] uniq = new int[cube.Length];
// Console.WriteLine(cube.Length);

FillArrayUniqNumbers(uniq);
PrintArray(uniq);



int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// void FillArrayUniqNumbers()

// // Standart version is filling the cube.
// void FillCube(int[,,] cube)
// {
//     for (int row = 0; row < cube.GetLength(0); row++)
//         for (int col = 0; col < cube.GetLength(1); col++)
//             for (int page = 0; page < cube.GetLength(2); page++)
//             {
//                 cube[row, col, page] = new Random.Next(1, 100);
//             }
// }

void FillArrayUniqNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int element = new Random().Next(10, 100);
        if (FindElement(array, element) == false) array[i] = element;
    }
}

bool FindElement(int[] uniq, int element)
{
    // int element = uniq[0];
    bool check = false;
    for (int i = 0; i < uniq.Length; i++)
    {
        if (element == uniq[i]) check = true;
    }
    return check;
}


// void FillCube(int[,,] cube, int[] uniq)
// {
//     int uniq = 0;
//     for (int row = 0; row < cube.GetLength(0); row++)
//         for (int col = 0; col < cube.GetLength(1); col++)
//             for (int page = 0; page < cube.GetLength(2); page++)
//             {
//                 int
//             }
// }