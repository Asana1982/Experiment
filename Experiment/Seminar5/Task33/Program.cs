Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int i = 0;
for (i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10); // [-9; 9]

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Введите число, которое Вы хотите найти: ");
int number = Convert.ToInt32(Console.ReadLine());
bool flag = true;
i = 0;
while (flag && i < n)
{
    if (array[i] == number)
        flag = false;
    i++;
}
if (flag)
    Console.WriteLine("no");
else
    Console.WriteLine("yes");