
/* **Задача 47:** Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

double[,] array = new double[3, 4];
for (int i = 0; i < array.GetLength(0); i++) //Строки
{
    for (int j = 0; j < array.GetLength(1); j++) // Столбцы
    {
        array[i, j] = new Random().Next(-10, 10) + Math.Round(new Random().NextDouble(), 3);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
    // Console.WriteLine(array.GetType());  // проверял, какие значения записаны в массив - целые или вещественные
}