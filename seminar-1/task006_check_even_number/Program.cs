// Input number. Check is even number?
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.Read());

if (number%2 == 0) {
    Console.WriteLine(" Чётное.");
}
else {
    Console.WriteLine(" Нечётное.");
}