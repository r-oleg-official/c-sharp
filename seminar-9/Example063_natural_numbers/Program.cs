Console.Write("Enter N: ");
int number = Convert.ToInt32(ReadLine());
Console.WriteLine(NaturalNumber(number));

int NaturalNumber(int number);
{
    if(number == 1)
        return 1;
    else
        Console.Write(NaturalNumber(number -1) + " ");
        return number;
}