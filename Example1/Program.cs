//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("Введено неправильное значение");
}

int secondNumber = (number % 100 - number % 10) / 10;

if (number > 100 & number < 1000)
{
    Console.WriteLine(secondNumber);
}

