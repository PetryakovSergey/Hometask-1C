Console.WriteLine("Введите трехзначное число : ");
int number = int.Parse(Console.ReadLine());
int third_number = number % 10; 
Console.WriteLine("Последняя цифра "+third_number);
