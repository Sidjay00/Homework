int[,] array = Fill2DArray();
PrintArray(array);
System.Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", AverageColumns(array))}");


double[] AverageColumns(int[,] array)
{
    double[] AvgArray = new double[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            // System.Console.WriteLine(array[j, i]);
            sum += array[j, i];


        }
        double avg = Math.Round(((double)sum / array.GetLength(0)), 2);
        AvgArray[i] = avg;
    }
    return AvgArray;
}

int[,] Fill2DArray()
{
    int[,] array = new int[3, 4];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    return array;
}

void PrintArray(Array arr)
{
    switch (arr.Rank)
    {
        case 1:
            for (int i = 0; i < arr.GetLength(0); i++)
                Console.Write($"{arr.GetValue(i)} ");
            break;
        case 2:
            for (int i = 0; i < arr.GetLength(0); i++) // Строки
            {
                for (int j = 0; j < arr.GetLength(1); j++) // Столбцы
                    Console.Write($"{arr.GetValue(i, j)} ");
                Console.WriteLine();
            }
            break;
        case 3:
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                        Console.Write($"{arr.GetValue(i, j, k)} ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            break;
    }
}