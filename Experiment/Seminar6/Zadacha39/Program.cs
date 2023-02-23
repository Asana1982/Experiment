//Переворот одномерного массива наоборот

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
  array[i] = new Random().Next(1, 11); // [1, 10]
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
for(int i = 0; i < array.Length / 2; i++) // цикл переворота одномерного массива (с конца в начало)
{
  int temp = array[i];
  array[i] = array[array.Length - 1 - i];
  array[array.Length - 1 - i] = temp;
}
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");