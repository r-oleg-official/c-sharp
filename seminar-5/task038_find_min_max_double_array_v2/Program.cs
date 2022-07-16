// Array is create a double type, fill a random numbers and displaying 
// the difference between min and max elements.
// My version.
int sizeArray = InputSize("Enter the array's size: ");
double[] arrayDouble = new double[sizeArray];

FillArray(arrayDouble);
PrintArray(arrayDouble);
double min_Element = FindMinElement(arrayDouble);
double max_Element = FindMaxElement(arrayDouble);

Console.WriteLine($" -> {max_Element - min_Element}");

int InputSize(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[] array)
{
    double a = 0, b = 0;
    for (int i = 0; i < array.Length; i++)
    {
        a = new Random().Next(-100, 100);
        b = new Random().Next(0, 100);
        array[i] = Convert.ToDouble($"{a},{b}");
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

double FindMaxElement(double[] array)
{
    double maxElement = array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }
        }
    return maxElement;
}

double FindMinElement(double[] array)
{
    double minElement = array[0];
    for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minElement)
            {
                minElement = array[i];
            }
        }
    return minElement;
}