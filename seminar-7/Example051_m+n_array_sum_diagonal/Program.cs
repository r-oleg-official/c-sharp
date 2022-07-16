// Create a two-demesional array. 
// Calculate score of elements in diagonal the array.
// Result: Сумма элементов главной диагонали: 1+9+2 = 12
// My version.

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] numbers = new int[m, n];
FillArray(numbers);
PrintArray(numbers);
string result = SumDiagonalElements(numbers);
Console.WriteLine($"Сумма элементов главной диагонали: {result}");

string SumDiagonalElements(int[,] array)
{
    int sum = array[0,0];
    string result = Convert.ToString(array[0,0]);
    for(int i = 1; i < array.GetLength(0); i++)
    {
        for(int j = 1; j < array.GetLength(1); j++)
        {
            if(i == j)
            {
                result  += "+" + array[i,j];
                sum += array[i,j];
            }
        }
    }
    result = result + " = " + sum;
    return result;
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