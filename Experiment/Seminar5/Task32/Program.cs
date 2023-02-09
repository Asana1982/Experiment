Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10); // [-9; 9]

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

for (int i = 0; i < array.Length; i++)
    array[i] *= (-1);

Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");