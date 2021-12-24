Console.WriteLine("Введите число ");
int x = int.Parse(Console.ReadLine()??"0");
if (x >= 100)
{
    while (x >= 1000)
        x = x / 10;
    int number = x % 10;
    Console.WriteLine("Третья цифра числа = " + number); 

}
else 
Console.WriteLine("В числе нет третьей цифры ");
