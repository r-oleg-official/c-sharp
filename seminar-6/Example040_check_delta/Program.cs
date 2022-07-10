// Entering three numbers and check is a delta?
// My version.

int sideA = InputNumber("Enter one number: ");
int sideB = InputNumber("Enter two number: ");
int sideC = InputNumber("Enter three number: ");

if (sideA < sideB + sideC &&
    sideB < sideA + sideC &&
    sideC < sideA + sideB)
{
    Console.WriteLine("This is delta!");
}
else 
{
    Console.WriteLine("This is not delta!");
}

int InputNumber(string msg)
{
    Console.Write(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}