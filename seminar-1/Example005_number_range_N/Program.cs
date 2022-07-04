//Input number N. Output to console range of the numbers from -N to N.
//My version.
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = -n; i < (n + 1); i++)
{
    if (i == n)
    {
        Console.WriteLine(i + ".");
    }
    else
    Console.Write(i + ", ");
}