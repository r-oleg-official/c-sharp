// Fill spiral array 4x4.
// Version by Denis.
int size = 4;
int[,] array = new int[size, size];

int value = 1;
int i = 0;
int j = 0;
while(value <= size * size)
{
    array[i, j] = value;
    if(i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++value;
}

for(int k = 0; k < array.GetLength(0); k++)
{
    for (int l = 0; l < array.GetLength(1); l++)
    {
        Console.Write(array[k, l] + " ");
    }
    Console.WriteLine();
}
