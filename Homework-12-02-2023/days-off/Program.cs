
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int number;
Console.Write($"Введите цифру дня недели: ");
int.TryParse(Console.ReadLine(), out number);

bool condition3 = number < 1;
bool condition4 = number > 7;

if (condition3 || condition4)
{
    Console.WriteLine($"Вы ввели некорректный день недели. Введите цифры от 1 до 7!");
}
else
{
    bool condition1 = number == 6;
    bool condition2 = number == 7;

    if (condition1 || condition2)
    {
        Console.WriteLine($"{number} -> этот день - выходной!");
    }
    else
    {
        Console.WriteLine($"{number} -> этот день - рабочий =(");
    }
}