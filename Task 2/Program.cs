Console.WriteLine("Введите 2 целых числа: ");
string a = Console.ReadLine();
string b = Console.ReadLine();
int number1;
int number2;


int.TryParse(a, out number1);
int.TryParse(b, out number2);

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