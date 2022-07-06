// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// My version.
int a = 645;
int b = 78;
int c = 32679;

Console.Write(a);
a = a % 10;
Console.WriteLine($" -> {a}");

Console.WriteLine($"{b} -> третьей цифры нет");

Console.Write(c);
c = c / 100;
c = c % 10;
Console.WriteLine($" -> {c}");
