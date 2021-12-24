int X = new Random().Next(10, 100);
Console.WriteLine("Число " + X);
int A = X % 10;
int B = X / 10;
if (A > B) 
{
    Console.WriteLine("Наибольшее число "+ A);
}
else
{
    Console.WriteLine("Наибольшее число "+ B);
}
