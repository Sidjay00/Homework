
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = new Random().Next();

string text = number.ToString();

Console.WriteLine($"{number} -> {text[2]}");