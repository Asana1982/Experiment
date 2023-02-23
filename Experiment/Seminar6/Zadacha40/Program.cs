// Написать программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник со сторонами такой длины.

Console.Clear();
Console.Write("Введите длину 1-ой стороны треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину 2-ой стороны треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину 3-й стороны треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a + b > c && b + c > a && a + c > b)
  Console.WriteLine("yes");
else
  Console.WriteLine("no");