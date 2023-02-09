Console.Clear();
int[] array = new int[12];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10); // [-9; 9]
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int sumNegative = 0, sumPositive = 0;
foreach(int element in array)
{
    if (element > 0)
        sumPositive += element;
    else
        sumNegative += element;
}
Console.WriteLine($"Сумма положительных чисел {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел {sumNegative}");