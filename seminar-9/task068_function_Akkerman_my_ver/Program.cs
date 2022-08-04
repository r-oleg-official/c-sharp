/*
The function by Akkerman. In the begin is have a two numbers M and N.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
My version.
*/

Console.Clear();
double m = GetInputValue("Enter a first number: "),
        n = GetInputValue("Enter a second number: ");

double sum = FunctionAkkerman(m, n);
Console.Write($"m = {m}; n = {n} -> A({m},{n}) = {sum}");
Console.WriteLine();

int GetInputValue(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double FunctionAkkerman(double firNumber, double secNumber)
{
    if (firNumber == 0 && secNumber > -1) return secNumber + 1;
    if (firNumber == 1 && secNumber > -1) return secNumber + 2;
    if (firNumber == 2 && secNumber > -1) return 2 * secNumber + 3;
    // if (firNumber == 3 && secNumber > -1) return Convert.ToInt64(Math.Pow(2, (secNumber + 3))) - 3;
    // if (firNumber > 2 && secNumber > -1) return secNumber = 2 ^ (FunctionAkkerman(firNumber - 1, secNumber - 1)) - 3;
    else return Math.Pow(2, (FunctionAkkerman(firNumber - 1, secNumber - 1))) - 3;
    // else return secNumber = 2 ^ ((secNumber - 1) + 3) - 3;
}
