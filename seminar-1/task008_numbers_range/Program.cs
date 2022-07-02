// Input number: N. See all even numbers from 1 to N.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count < number) {
       Console.Write(count);
        if (count == number -2) {
            Console.Write(".");
        }
        else {
        Console.Write(", ");
        }
    count = count + 2;    
}