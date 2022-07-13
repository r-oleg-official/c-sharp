// User is entering array of a numbers. Need calculate sum of the positive numbers. 
// My version.
int sizeArray = InputSize("Enter size of a array: ");
double[] arrayUser = new double[sizeArray];

FillArray(arrayUser);
PrintArray(arrayUser);

Console.WriteLine($" -> {CalcPositiveElements(arrayUser)}");

int InputSize(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i+1}-й: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                Console.Write($"[{array[i]};");
            }
            else if (i == array.Length - 1)
            {
                Console.Write($"{array[i]}]");
            }
            else
            {
                Console.Write($"{array[i]};");
            }
        }
}

int CalcPositiveElements(double[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0 )
            {
                sum++;
            }
        }
    return sum;
}