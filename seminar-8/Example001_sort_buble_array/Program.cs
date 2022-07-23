// Buble sort one-dimensional array.
int columns = GetInputValue("Enter a number size array: ");
int[] sArray = new int[columns];
FillArray(sArray);
PrintArray(sArray);



// в цикле прогонять массив И-раз 
for (int k = 0; k < sArray.GetLength(0); k++)
{
    sd
}





// метод на проход массива
int pass1(int[] array)
{
    int tempVar = array[0];


}



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