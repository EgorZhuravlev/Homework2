/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

bool isParsed = int.TryParse(Console.ReadLine(), out int n);

if (!isParsed)
{
    Console.WriteLine("Введено неправильное значение");
}

if (n >= 100)
{
    while (n > 999)
    {
        n /= 10;
    }
    int result = n % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьего числа нет");
}
