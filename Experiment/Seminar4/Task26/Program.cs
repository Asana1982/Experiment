// Задача 26
// Напишите программу, которая принимает на вход число и
// выдает количество цифр в числе 
Console.Clear();
Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()), count = 0;
// while (n > 0)
// {
//     n = n / 10;
//     count++;
// }
// Console.WriteLine($"Результат: {count}");

// ИЛИ

string? n = Console.ReadLine();
Console.WriteLine($"Результат: {n.Length}");