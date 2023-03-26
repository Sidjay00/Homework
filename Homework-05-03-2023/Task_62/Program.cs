/* **Задача 62: **  Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int n = 4;
int[,] array = new int[n, n];
int number = 1;
int MinStrIndex = 0, MaxStrIndex = array.GetLength(0)-1, MinColIndex = 0, MaxColIndex = array.GetLength(1)-1;

while (number <= n * n)
{
    for (int j = MinColIndex; j <= MaxColIndex; j++)    //0.3
    {
        array[MinStrIndex, j] = number; //0 AND CYCLE
        number++;
    }
    MinStrIndex++; // 1
    for (int i = MinStrIndex; i <= MaxStrIndex; i++) //1.3
    {
        array[i, MaxColIndex] = number; //cycle and 3
        number++;
    }
    MaxColIndex--; // 2
    for (int j = MaxColIndex; j >= MinColIndex; j--)   //   2.0
    {
        array[MaxStrIndex, j] = number; // 3 and cycle
        number++;
    }
    MaxStrIndex--; // 2
    for (int i = MaxStrIndex; i >= MinStrIndex; i--)   //2.1
    {
        array[i, MinColIndex] = number; //0
        number++;
    }
    MinColIndex++; //1
}

PrintArray(array);

void PrintArray(Array array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array.GetValue(i, j):00} ");
        }
        System.Console.WriteLine();
    }
}