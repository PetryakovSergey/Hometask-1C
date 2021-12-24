Console.Write("Введите число  ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число  ");
int numberB = int.Parse(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.WriteLine("число А является квадратом числа В");
}
else
{
    Console.WriteLine("число А не является квадратом числа В");
}