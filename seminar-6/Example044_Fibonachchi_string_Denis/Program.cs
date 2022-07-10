// Entering number N and displaying numbers of a Fibonachchi.
// First and second numbers of the Fibonachchi: 0 and 1.
// Version Denis.
int count = InputInt("Введите, сколько чисел вы хотите вывести: ");
string result = string.Empty;
int first = 0;
int second = 1;

if(count > 0)
  result += first + " ";
if(count > 1)
  result += second + " ";

for(int i = 2; i < count; i++)
{
  int next = first + second;
  result += next + " " ;
  first = second;
  second = next;
}
Console.WriteLine(result);

int InputInt(string str)
{
  Console.Write(str);
  return Convert.ToInt32(Console.ReadLine());
}