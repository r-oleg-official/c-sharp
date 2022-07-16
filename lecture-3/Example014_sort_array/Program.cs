// Sort array.
//Console.WriteLine("Hello, World!");

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // -1 - т.к. j=i+1.
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 1, 1, 1 };
PrintArray(arr);
// "...Удивительно, но код запустился м первого раза..." 0:31:19
SelectionSort(arr);
PrintArray(arr);