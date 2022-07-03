//Найти сумму ряда чисел до A
Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int count = 1;
while (count <= a)
{
    sum += count; // sum = sum + count
    count++;
}
Console.WriteLine("Сумма чисел от 1 до " + a + ": " + sum + ".");

//circle "for"
sum = 0;
for (int i = 1; i <= a; i++)
{
    sum += i;
}
Console.WriteLine("Сумма чисел от 1 до " + a + ": " + sum + ".");