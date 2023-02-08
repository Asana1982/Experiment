// Console.Clear();
// Console.WriteLine("Введите код четверти от 1 до 4:  ");
// double number_Quarter = Convert.ToDouble(Console.ReadLine());
// if (number_Quarter == 1)
//     Console.WriteLine("x > 0 && y > 0");
// if (number_Quarter == 2)
//     Console.WriteLine("x < 0 && y > 0)");
// if (number_Quarter == 3)
//     Console.WriteLine("x < 0 && y < 0)");
// if (number_Quarter == 4)
//     Console.WriteLine("x > 0 && y < 0)");
//  if (number_Quarter != 1 && number_Quarter != 2 && number_Quarter != 3 && number_Quarter != 4);
//     Console.WriteLine("Введите код четверти от 1 до 4:  ");
   
Console.Clear();
Console.WriteLine("Введите номер четверти:  ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 4)
{
    Console.WriteLine("Вы ошиблись !\nВведите номер четверти:  ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
    Console.WriteLine("x > 0 and y > 0");
else if (n == 2)
    Console.WriteLine("x < 0 and y > 0");
else if (n == 3)
    Console.WriteLine("x < 0 and y > 0");
if (n == 4)
    Console.WriteLine("x > 0 and y < 0");