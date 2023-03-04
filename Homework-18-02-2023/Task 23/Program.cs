/* Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125 */

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine(), out N);

Console.Write($"{N} -> ");
for (int i = 1; i <= N; i++)
{
    Console.Write($"{i * i * i}, ");
}