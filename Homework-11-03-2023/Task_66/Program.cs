/*  **Задача 66:** Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


int m, n;
Console.Write($"Введите число M: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine(), out n);

Console.WriteLine($"M = {m}; N = {n} -> {PrintSum(m, n)}");

int PrintSum(int m, int n)
{
    if (m >= n)
        return m;
    return m += PrintSum(m + 1, n); //  Снова пишу для себя, так как совершил ошибку на переполнение. Нельзя вызывать рекурсию без изменения переменной, иначе будет зацикливание
}