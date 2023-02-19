
// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает **вторую** цифру этого числа.

int number;

number = new Random().Next(100, 1000);

int a = number % 100;
int b = a / 10;

Console.WriteLine($"{number} -> {b}");