/* **Задача 54: **  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] array = Fill2DArray();
PrintArray(array);
System.Console.WriteLine();
Sort(array);
PrintArray(array);

void Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxPosition]) maxPosition = k;
            }
            (array[i, j], array[i, maxPosition]) = (array[i, maxPosition], array[i, j]);
        }
    }
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