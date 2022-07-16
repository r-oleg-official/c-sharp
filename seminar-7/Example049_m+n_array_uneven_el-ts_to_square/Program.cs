// Specify a two-dimensional array. Find elements that have both uneven indices 
// and replace those elements with their squares.
// My version.

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] numbers = new int[m, n];
FillArray(numbers);
PrintArray(numbers);
ReplaceUnvenElements(numbers);
PrintArray(numbers);

void ReplaceUnvenElements(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 > 0 && j % 2 > 0)
            {
                array[i,j] = array[i,j] * array[i,j];
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}