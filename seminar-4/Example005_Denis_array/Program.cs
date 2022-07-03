// 
int[] array = new int[8];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}
PrintArray(array);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }   
    Console.WriteLine();
}
