// напишите программу которая принимает на вход число N и выдает произведение числе от 1 до N 

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), result = 1;
for (int i = 1; i <= n; i++)
    result *= i;
System.Console.WriteLine($"Результат: {result}");