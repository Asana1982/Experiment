Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 161 == 0)
    Console.WriteLine("кратно");
else
    Console.WriteLine("не кратно");