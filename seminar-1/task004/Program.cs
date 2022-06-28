Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int c = Convert.ToInt32(Console.ReadLine());
int max;
if (b < a && b > c) {
    max = b;
}
if (a < b && b > c) {
    max = b;
}
else {
    max = c;
}
Console.WriteLine("Maximum number: " + max);