int firstSide = InputInt("Введите длину сторону А: ");
int secondSide = InputInt("Введите длину сторону B: ");
int thirdSecond = InputInt("Введите длину сторону С: ");

if(firstSide < secondSide + thirdSecond && 
   secondSide < firstSide + thirdSecond && 
   thirdSecond < secondSide + firstSide )
{
    Console.WriteLine("Существует");
}
else
{
    Console.WriteLine("Не существует");
}


int InputInt(string output)
{
  Console.Write(output);
  return Convert.ToInt32(Console.ReadLine());
}