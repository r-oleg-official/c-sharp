// Buble sort one-dimensional array.
int columns = GetInputValue("Enter a number size array: ");
int[] sArray = new int[columns];
FillArray(sArray);
PrintArray(sArray);

for (int k = 0; k < sArray.GetLength(0) - 1; k++)
{
    // перед входом в цикл "check=true"
    int tempVar = 0;
    bool check = true;
    for (int i = 0; i < sArray.GetLength(0) - 1 - k; i++)
    {
        if (sArray[i] > sArray[i+1])
        {
            tempVar = sArray[i+1];
            sArray[i+1] = sArray[i];
            sArray[i] = tempVar;
            check = false;
        }
    }
    // если во время прохода были замены, цикл повториться.
    if (check == true) break; 
}

PrintArray(sArray);

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = Convert.ToInt32(new Random().Next(0, 10));
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}