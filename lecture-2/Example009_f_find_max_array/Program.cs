// Find max number from a 9 numbers, using array.

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
// indexes    0   1   2   3   4   5   6   7   8
int[] array = { 15, 21, 39, 11, 12, 18, 55, 78, 99 };

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);