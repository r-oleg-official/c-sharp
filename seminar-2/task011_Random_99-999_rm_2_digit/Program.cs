// Displaying a random number 99-999, remove two digit of the number. Displaying the result.
// My version.
int randomNumber = new Random().Next(100, 1000);
string digit2 = $"{randomNumber / 100}{randomNumber % 10}";
int result = Convert.ToInt32(digit2);
Console.WriteLine($"Случайное число = {randomNumber}, результат = {digit2}");