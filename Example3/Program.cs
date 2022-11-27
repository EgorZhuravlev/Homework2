//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

bool isParsed = int.TryParse(Console.ReadLine(), out int n);

if (n >=1 && n <= 5)
{
    Console.WriteLine("Это будний день");
}
else if (n >= 6 && n <= 7)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Такого дня не существует");
}