// Displaying a random number 99-999, remove two digit of the number. Displaying the result.
// My version 2.0.
int randomNumber = new Random().Next(100, 1000);
int digit1 = randomNumber / 100;
int digit2 = randomNumber % 10;
int result = digit1 * 10 + digit2;
Console.WriteLine("Cлучайное число: " + randomNumber);
Console.WriteLine("Результат: " +result);