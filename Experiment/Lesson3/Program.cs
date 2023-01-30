int[] array = {17, 13, 34, 57, 12, 67, 91, 107, 34};

int n = array.Length;
int find = 34;

int index = 0;

while (index < n)
{
    if (array[index] == find)
{
    Console.WriteLine(index);
    break;
}
    index ++;
}
