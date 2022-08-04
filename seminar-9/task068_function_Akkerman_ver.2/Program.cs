/*
The function by Akkerman. In the begin is have a two numbers M and N.
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();
int m = GetInputValue("Enter a first number: "),
    n = GetInputValue("Enter a second number: "),
    depth = 0;
if (m < 0 || n < 0) return;
Console.Clear();

Console.WriteLine($"m = {m}; n = {n} -> A({m},{n}) = {FunctionAkkerman(m, n)}");
if (depth < 0) depth = depth * -1;
Console.WriteLine($"Counter - {depth}");

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int FunctionAkkerman(int firNumber, int secNumber)
{
    depth++;
    if (firNumber == 0) return secNumber + 1;
    if (secNumber == 0) return FunctionAkkerman(firNumber - 1, 1);
    else return FunctionAkkerman(firNumber - 1, FunctionAkkerman(firNumber, secNumber - 1));

}
