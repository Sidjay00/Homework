Console.WriteLine("Введите 2 целых числа: ");
int number1;
int number2;


int.TryParse(Console.ReadLine(), out number1);
int.TryParse(Console.ReadLine(), out number2);

if (number1 > number2)
{
    Console.WriteLine($"Число {number1} больше, чем {number2}.");
}
else
{
    Console.WriteLine($"Число {number2} больше, чем {number1}.");
}

/*string text = Console.ReadLine();
int number = int.Parse(text);

Console.WriteLine(number);*/