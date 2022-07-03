// Определение кол-ва разрядов числа.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество разрядов числа " + num + ": ");

int count =0;
while (num > 0)
{
    num = num / 10;
    count++;
}
Console.WriteLine(count + ".");