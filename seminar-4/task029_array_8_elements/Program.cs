// Create array with eight elements and displaying him.
// My version.
int size = InputSizeArray("Enter a size of array, number: ");
int[] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int InputSizeArray(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"[{array[i]},");
        }
        else if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}]");    
        }
        else
        {
        Console.Write($"{array[i]},");
        }
    }
}