// Input two numbers, find max'n'min number.
int max_number = 0, min_number = 0;

Console.Write("Введите первое число ");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int second_number = Convert.ToInt32(Console.ReadLine());

if (first_number > second_number) {
    max_number = first_number;
    min_number = second_number;
}
else {
    min_number = first_number;
    max_number = second_number;
}
Console.WriteLine("Максимальное число: " + max_number);
Console.WriteLine("Минимальное число: " + min_number);