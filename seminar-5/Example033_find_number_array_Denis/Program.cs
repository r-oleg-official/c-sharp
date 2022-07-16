int size = InputInt("Введите размер массива: ");
int[] numbers = new int[size];

FillArray(numbers);
PrintArray(numbers);

int searchNumber = InputInt("Введите число: ");
bool isTrue = false;

for(int i = 0; i< numbers.Length; i++)
{
  if(numbers[i] == searchNumber)
  {
    isTrue = true;
    break;
  }
}
if(isTrue)
  Console.WriteLine("Да");
else
  Console.WriteLine("Нет");


int InputInt(string output)
{
  Console.Write(output);
  return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
  for(int i = 0; i< array.Length; i++)
  {
    array[i] = new Random().Next(-9, 10);
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