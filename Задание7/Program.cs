Console.WriteLine("Введите трехзначное число ");
int x = int.Parse(Console.ReadLine()??"0");
int A = x / 100;
int C = x % 10;
Console.Write("Новое число "+  A);
Console.Write(""+ C);
