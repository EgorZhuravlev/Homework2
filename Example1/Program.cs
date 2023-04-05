

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

