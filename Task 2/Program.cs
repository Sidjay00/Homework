Console.Write("Введите 2 целых числа: ");
string a = Console.ReadLine();
string b = Console.ReadLine();

if (a > b)
{
    Console.WriteLine($"Число {a} больше, чем {b}.");
}
else
{
    Console.WriteLine($"Число {b} больше, чем {a}.");
}