//Input number N. Output to console range of the numbers from -N to N.
//Version by Sasha.
int a = 5;
int b = -a;
string c = "";
while (b <= a)
{
    c = c + ", " + b++;
}
Console.WriteLine(c);
// Output: , -5, -4, -3, -2, -1, 0, 1, 2, 3, 4