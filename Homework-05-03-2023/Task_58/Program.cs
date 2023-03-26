/* **Задача 58: **  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] matrix1 = Fill2DArray();
int[,] matrix2 = Fill2DArray();
int[,] ResultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        System.Console.Write($"{matrix1.GetValue(i, j)} ");
    }
    System.Console.Write("| ");
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        System.Console.Write($"{matrix2.GetValue(i, j)} ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    System.Console.WriteLine($"Данные матрицы перемножить между собой нельзя!");
    return;
}


for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
        for (int n = 0; n < matrix1.GetLength(1); n++)
            ResultMatrix[i, j] += matrix1[i, n] * matrix2[n, j];
}

PrintArray(ResultMatrix);



    int[,] Fill2DArray()
    {
        int[,] arr = new int[3, 3];
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

    static int[,] ReadMatrix(string message)
    {
        System.Console.WriteLine(message);
        System.Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine()!);
        System.Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine()!);
        int[,] matrix = new int[rows, cols];
        System.Console.WriteLine("Введите элементы матрицы:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"[{i}, {j}]: ");
                matrix[i,j] = int.Parse(Console.ReadLine()!);
            }
        }
        return matrix;
    }