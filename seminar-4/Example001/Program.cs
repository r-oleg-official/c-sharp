//Найти сумму ряда чисел до A
Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int count = 1;
while (count <= a)
{
    sum += count; // sum = sum + count
    count++;
}
Console.WriteLine(sum);

for (int i = 1; i <= a; i++)
{
    sum += i;
}
Console.WriteLine(sum);