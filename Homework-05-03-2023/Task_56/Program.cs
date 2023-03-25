/* **Задача 56: **  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] array = Fill2DArray();
PrintArray(array);
System.Console.WriteLine();
int[] arr = SumOfStrings(array);



int minPosition = 1;
for (int i = 1; i < arr.GetLength(0); i++)
{
    if (arr[i] < arr[i - 1])
        minPosition = i+1;
}
System.Console.WriteLine($"Строка №{minPosition} с наименьшей суммой элементов.");

int[] SumOfStrings(int[,] arr)
{
    int[] SumOfStrings = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        SumOfStrings[i] = sum;
    }
    return SumOfStrings;
}

int[,] Fill2DArray()
{
    int[,] arr = new int[3, 4];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(10);
    return arr;
}

void PrintArray(Array array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array.GetValue(i, j)} ");
        }
        System.Console.WriteLine();
    }
}