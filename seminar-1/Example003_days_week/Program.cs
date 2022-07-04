// Ввод: день недели по номеру. Вывод: название дня недели.
// My version.
Console.Write("Введите день недели числом от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("Понедельник.");
}
if (day == 2)
{
    Console.WriteLine("Вторник.");
}
if (day == 3)
{
    Console.WriteLine("Среда.");
}
if (day == 4)
{
    Console.WriteLine("Четверг.");
}
if (day == 5)
{
    Console.WriteLine("Пятница.");
}
if (day == 6)
{
    Console.WriteLine("Суббота.");
}
if (day == 7)
{
    Console.WriteLine("Воскресенье.");
}
if (day < 1 | day > 7)
{
    Console.WriteLine("Введен неверный номер дня недели. Введите от 1 до 7.");
}