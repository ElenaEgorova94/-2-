// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int res = 0;
while (N > 999) 
{
    res = N / 10;
    N = res;
}

if (N < 1000 && N > 99)
{
    N = N % 10;
    Console.WriteLine("Третья цифра у заданного числа - " + N);
}
else if (N < 100)
{
    Console.WriteLine("Третьей цифры у заданного числа нет");
}