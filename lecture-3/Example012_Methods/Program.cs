// View group methods 1.
void Method1()
{
    Console.WriteLine("Author ...");
}
Method1();

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Text message");

void Method21(string msg)
{
    Console.WriteLine(msg);
}
// Бывают именованные аргументы. Когда нужно какому именно аргументу какое 
// значение необходимо указать. Когда много аргументов.
Method21(msg: "Name message");

void Method22(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method22("Text", 4);
// or
Method22(msg: "Text2", count: 4);
Method22(count: 4, msg: "Text3");


// View group methods 2.

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // - так лучше задавать пустую переменную
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string Method41(int count, string text)
{
    string result = String.Empty; // - так лучше задавать пустую переменную
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "x");
Console.WriteLine(res);

res = Method41(10, "y");
Console.WriteLine(res);