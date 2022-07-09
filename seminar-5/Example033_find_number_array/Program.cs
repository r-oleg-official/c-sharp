// Find number to array.
Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length];

FillArray(numbers);
PrintArray(numbers);
Console.WriteLine("Введите число для поиска в массиве: ");
int findNumber = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == findNumber)
    {
        Console.WriteLine("-> да.");
        return;
    }
}
Console.WriteLine("-> нет.");

void FillArray(int[] array)
{
  for(int i = 0; i< array.Length; i++)
  {
    array[i] = new Random().Next(9, 100);
  }
}

void PrintArray(int[] array)
{
  for(int i = 0; i< array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}