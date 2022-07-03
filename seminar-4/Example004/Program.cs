// int[] array = new int[8]; //new clear array with length =8.
//int [] numbers = {1, 2, 3, 4};
//int[] array = new int[8];
//new Random().Next(1, 10)
//
//void PrintArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i] + " ");
//    }    
//    Console.WriteLine();
//}

// Создать массив из 0 и 1 любого размера.
Console.Write("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i]+" ");
}
Console.WriteLine();