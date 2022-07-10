// Array is create, fill a random positive numbers and displaying the count of even numbers.
// My version.
int sizeArray = InputSize("Enter size of a array: ");
int[] arrayPositive = new int[sizeArray];

FillArray(arrayPositive);
PrintArray(arrayPositive);
Console.WriteLine($" -> {CalcEvenNumbers(arrayPositive)}");

int InputSize(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) count++;
        }
    return count;
}