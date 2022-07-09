int size = InputInt("Введите размер: ");
int[] numbers = new int[size];
int[] multiplyPairs;
FillArray(numbers);
PrintArray(numbers);
if(numbers.Length % 2 == 0)
{
  multiplyPairs = new int[numbers.Length / 2];
}
else
{
  multiplyPairs = new int[numbers.Length / 2 + 1];
  multiplyPairs[multiplyPairs.Length - 1] = numbers[numbers.Length / 2];
}

for(int i = 0; i < numbers.Length / 2; i++)
{
  multiplyPairs[i] = numbers[i] * numbers[numbers.Length - 1 - i];
}
PrintArray(multiplyPairs);


int InputInt(string output)
{
  Console.Write(output);
  return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
  for(int i = 0; i< array.Length; i++)
  {
    array[i] = new Random().Next(1, 124);
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