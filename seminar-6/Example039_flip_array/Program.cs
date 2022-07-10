﻿int size = InputInt("Введите размер: ");
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);

for(int i = 0; i < numbers.Length / 2; i++)
{
  int temp = numbers[i];
  numbers[i] = numbers[numbers.Length - 1 - i];
  numbers[numbers.Length - 1 - i] = temp;
}

PrintArray(numbers);

int InputInt(string output)
{
  Console.Write(output);
  return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
  for(int i = 0; i< array.Length; i++)
  {
    array[i] = new Random().Next(1, 10);
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