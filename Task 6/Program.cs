Console.WriteLine("Введите целое число: ");
int number;
int.TryParse(Console.ReadLine(), out number);

if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} четное");
}
else
{
    Console.WriteLine($"Число {number} нечетное");
}