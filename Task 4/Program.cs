Console.WriteLine("Введите 3 целых числа: ");
int number1;
int number2;
int number3;
int max;
int.TryParse(Console.ReadLine(), out number1);
int.TryParse(Console.ReadLine(), out number2);
int.TryParse(Console.ReadLine(), out number3);

if (number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}

if (max < number3)
{
    max = number3;
}

Console.WriteLine($"Число {max} наибольшее из 3 чисел");