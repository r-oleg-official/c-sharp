// Input number: N. See all even numbers from 1 to N.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count <= number) {
        if (count == number) {
            Console.WriteLine(count + "."); 
        }
        else {
            Console.Write(count + ", "); 
        }
        count = count + 2;    
}