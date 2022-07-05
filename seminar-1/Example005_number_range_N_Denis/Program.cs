// Input number N. Output to console range of the numbers from -N to N.
// Version by Denis.
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int min = -n;

while (min <= n)
{
    Console.Write(min + " ");
    min++;
}
// compact version of circle.
//while (min <= n)
//{
//    Console.Write(min++ + " ");
//}