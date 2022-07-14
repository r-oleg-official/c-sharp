// Find element into array.

// indexes      0   1   2   3   4   5   6   7   8
int[] array = {15, 21, 39, 11, 12, 18, 55, 78, 99};
int n = array.Length;
int find = 11;

int index = 0;
while (index < n)
{
    if (array[index] == find)
        {
            Console.WriteLine(index);
            break; // прервет цикл на 1-м срабатывании.
        }
    index++;
}