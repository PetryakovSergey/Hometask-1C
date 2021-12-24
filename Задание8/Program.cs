int x = new Random().Next (1, 100);
Console.WriteLine("Первое число = " + x);
Console.WriteLine("Введите второе число ");
int y = int.Parse(Console.ReadLine()??"0");
int xy = x % y; 
if (xy == 0)
{
    Console.WriteLine("Первое число кратно второму числу ");
}
else 
{
    Console.WriteLine("Остаток от деления = "+ xy);
}