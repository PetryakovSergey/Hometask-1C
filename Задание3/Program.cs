Console.Write("Введите число N ");
int x = int.Parse(Console.ReadLine());
int i = 0;
while (i <= x * 2)
{
    int counts = -x + i;
    Console.Write(counts + " ");   
    i ++;
}