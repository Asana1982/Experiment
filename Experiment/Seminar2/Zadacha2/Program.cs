Console.Clear ();
int n = new Random().Next(100, 1000); //[100, 999]
Console.WriteLine(n);
int n1 = n / 100;
n1 = n1 * 10;
int n2 = n % 10;
int k = n1 + n2;
Console.WriteLine(k);
