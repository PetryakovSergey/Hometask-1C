Console.WriteLine("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine()??"0");
int i = number % 100;
int second_number = i/10;
Console.WriteLine("Второе число " +second_number);
