// Entering number N and displaying numbers of a Fibonachchi.
// First and second numbers of the Fibonachchi: 0 and 1.
// Version Denis with array.
int count = InputInt("Введите, сколько чисел вы хотите вывести: ");
int[] fibinacciNumbers = new int[count];

if(fibinacciNumbers.Length > 0)
  fibinacciNumbers[0] = 0;
if(fibinacciNumbers.Length > 1)
  fibinacciNumbers[1] = 1;

for(int i = 2; i < fibinacciNumbers.Length; i++)
{
  fibinacciNumbers[i] = fibinacciNumbers[i - 1] + fibinacciNumbers[i - 2];
}
PrintArray(fibinacciNumbers);

int InputInt(string str)
{
  Console.Write(str);
  return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
	{
	  for(int i = 0; i< array.Length; i++)
	  {
	    Console.Write(array[i] + " ");
	  }
	  Console.WriteLine();
	}