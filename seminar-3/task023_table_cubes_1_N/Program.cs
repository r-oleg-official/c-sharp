// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Entering a number and displaying table of the numbers in cubes.
Console.Write("Enter a number N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 )
{
    Console.WriteLine("Error! Need enter a number from one and high.");
}
else
{
    Console.Write($"{number} -> ");
    for (int i =1; i < number; i++)
    {
        int result = i * i * i;
        Console.Write($"{result}, ");
    }
    number = number * number * number;
    Console.WriteLine($"{number}.");
}