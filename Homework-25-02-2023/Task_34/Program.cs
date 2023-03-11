/* **Задача 34:** Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] array = FillArray(12, 100, 1000);
int Odds = 0;

foreach (int item in array)   //Здесь item - это элемент массива.
{
    if (item % 2 == 0)
        Odds += 1;
}

Console.WriteLine($"[{String.Join(", ", array)}] -> количество четных чисел в массиве - {Odds}");

int[] FillArray(int size, int min = 0, int max = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}