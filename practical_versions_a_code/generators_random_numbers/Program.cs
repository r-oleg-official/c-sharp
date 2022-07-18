// A different versions are a generators random numbers.

Random random = new Random();

int randomInteger = random.Next(0, 100);
//                                          (max - min) + min
double randomDouble = random.NextDouble() * (100 - 0) + 0;
decimal randomDecimal = Convert.ToDecimal(random.NextDouble() * (100 - 0) + 0);
float randomSingle = random.NextSingle() * (100 - 0) + 0;

Console.WriteLine($"random = {random}");
Console.WriteLine($"randomInteger = {randomInteger}");
Console.WriteLine($"randomDouble = {randomDouble}");
Console.WriteLine($"randomDecimal = {randomDecimal}");
Console.WriteLine($"randomSingle = {randomSingle}");