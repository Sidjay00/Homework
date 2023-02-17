Console.WriteLine("Введите 2 целых числа: ");
string a = Console.ReadLine();
string b = Console.ReadLine();

int number1 = int.Parse(a);
int number2 = int.Parse(b);

if (number1 > number2)
{
    Console.WriteLine($"Число {a} больше, чем {b}.");
}
else
{
    Console.WriteLine($"Число {b} больше, чем {a}.");
}

/*string text = Console.ReadLine();
int number = int.Parse(text);

Console.WriteLine(number);*/