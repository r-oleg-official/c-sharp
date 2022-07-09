// Find pairs of extreme elements, multiply them and write them to a new array.
int[] numbers = new int[5];
FillArray(numbers);

int maxIndex = numbers.Length;
int[] result;

if (numbers.Length % 2 == 0)
{
    
    result = new int[maxIndex / 2];
    for (int i = 0; i < maxIndex / 2; i++)
        {
            result[i] = numbers[i] * numbers[maxIndex - 1 - i];
            //maxIndex = maxIndex - 1;
        }
}
else
{
    result = new int[maxIndex / 2 + 1];
    for (int i = 0; i < maxIndex / 2; i++)
        {
            result[i] = numbers[i] * numbers[maxIndex - 1 - i];
        }
    result[maxIndex / 2 ] = numbers[maxIndex / 2];
}

PrintArray(numbers);
PrintArray(result);

void FillArray(int[] array)
{
  for(int i = 0; i< array.Length; i++)
  {
    array[i] = new Random().Next(0, 100);
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