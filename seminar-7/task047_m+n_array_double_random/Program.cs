// Create a two-demesional array, filling a double random numbers. 
// My version.

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
double[,] numbers = new double[m, n];
FillArray(numbers);
PrintArray(numbers);

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(-100, 100);
        }
    }
}

void PrintArray(double[,] array)
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