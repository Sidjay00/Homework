
ShowSecondNumber();

int InputNumber()
{
    int number;
    Console.Write("Введите трехзначное число: ");
    string text = Console.ReadLine();
    int.TryParse(text, out number);
    if (number > 100 && number < 999)
        return number;
    else
    {
        Console.WriteLine("Вы ввели не трехзначное число");
        return InputNumber();
    }
}


void ShowSecondNumber()
{
    string text = InputNumber().ToString();
    Console.WriteLine($"{text} -> {text[1]}");
}

// int a = number % 100;
// int b = a / 10;

// Console.WriteLine($"{number} -> {b}");