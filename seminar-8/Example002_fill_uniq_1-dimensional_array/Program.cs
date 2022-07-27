// Create a array and filling by uniq integer numbers.
// My version.
Console.Clear();
int minValue = GetInputValue("Enter a minimal number of the array: ");
int maxValue = GetInputValue("Enter a maximal number of the array: ");
// int size = GetInputValue("Enter a size array: ");
int[] uniq = new int[maxValue - minValue];
// Console.WriteLine(uniq.Length);

FillArrayUniqNumbers(uniq, minValue, maxValue);
PrintArray(uniq);

Console.WriteLine();
SortArray(uniq);
PrintArray(uniq);

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// void FillArrayUniqNumbers(int[] array, int minValue, int maxValue)
// {
//     for (int k = 0; k < array.Length; k++)
//     { // fill array
//         int element = new Random().Next(minValue, maxValue);
//         bool check = false;
//         for (int i = 0; i < array.Length; i++)
//         { // check uniq element
//             if (array[i] == element) check = true;
//             if (check == false) array[k] = element;
//         }
//     }
// }

// version-2
void FillArrayUniqNumbers(int[] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        bool isUnique;
        do
        {
            array[i] = new Random().Next(minValue, maxValue);
            isUnique = true;
            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    isUnique = false;
                    break;
                }
            }
        } while (!isUnique);
    }
}

void SortArray(int[] array)
{
    bool stopSort = true;
    for (int k = 0; k < array.Length; k++)
    {
        int temp = 0;
        for (int i = 0; i < array.Length - 1 - k; i++)
        {
            if (array[i] > array[i + 1])
            {
                temp = array[i + 1];
                array[i + 1] = array[i];
                array[i] = temp;
            }
            stopSort = false;
        }
        if (stopSort == true) return;
    }
}