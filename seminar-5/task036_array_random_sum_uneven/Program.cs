// Array is create, fill a random numbers and displaying the sum of uneven elements.
// My version.
int sizeArray = InputSize("Enter size of a array: ");
int[] arrayRandom = new int[sizeArray];

FillArray(arrayRandom);
PrintArray(arrayRandom);
Console.WriteLine($" -> {CalcEvenNumbers(arrayRandom)}");

int InputSize(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
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

int CalcEvenNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 1)
            {
                sum = sum + array[i];
            }
        }
    return sum;
}