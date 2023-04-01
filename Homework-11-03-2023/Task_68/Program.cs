/*  **Задача 68:** Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */


int m, n;
Console.Write($"Введите неотрицательное число M: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите неотрицательное число N: ");
int.TryParse(Console.ReadLine(), out n);

if (m < 0 || n < 0)
{
    Console.WriteLine("Вы ввели отрицательное число. Решения нет!");
    return;
}
Console.WriteLine($"M = {m}; N = {n} -> {Ack(m, n)}");

int Ack(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Ack(m - 1, 1);
    return Ack(m - 1, Ack(m, n - 1));
}