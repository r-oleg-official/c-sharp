// View group methods 1.
void Method1()
{
    Console.WriteLine("Hello, World!");
}
Method1();

// View group methods 2.
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Text message");

void Method3(string msg)
{
    Console.WriteLine(msg);
}
// Бывают именованные аргументы. Когда нужно какому именно аргументу какое 
// значение необходимо указать.
Method3(msg: "Name message");

void Method21(string msg, int count)
{
    int i =0;
    while (i < count)
    {
        Console.WriteLine(msg);    
        i++;
    }
    
}
Method21("Text", 4);
// or
Method21(msg: "Text2", count: 4);
Method21(count: 4, msg: "Text3");

// View group methods 3.

