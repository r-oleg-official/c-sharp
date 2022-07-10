// Create copy a array.
// Version by Denis.
int size = InputInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArray(numbers);
int[] newNumbers = CopyArray(numbers);

PrintArray(numbers);
PrintArray(newNumbers);

int[] CopyArray(int[] array)
{
  int[] copyArray = new int[array.Length];
  for(int i = 0; i < copyArray.Length; i++)
  {
    copyArray[i] = array[i];
  }
  return copyArray;
}

int InputInt(string str)
{
  Console.Write(str);
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