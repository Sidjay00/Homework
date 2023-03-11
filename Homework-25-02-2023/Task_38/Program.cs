/* **Задача 38:** Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

// /home/sysadmin/Dev/GeekBrains/Homework/Homework-25-02-2023/Task_38/Program.cs(11,8): error CS0161: 
// "MaxMinDif(double[])": не все пути к коду возвращают значение. 
// [/home/sysadmin/Dev/GeekBrains/Homework/Homework-25-02-2023/Task_38/Task_38.csproj]
// периодически возникает такая ошибка - это происходит из-за того, что я return ставлю внутри цикла for. NB!

double[] arr = FillArray(4, -100, 100);

System.Console.WriteLine($"[{String.Join(", ", arr)}] -> {MaxMinDif(arr)}");

double MaxMinDif(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    double dif = 0;

    for (int i = 1; i < arr.Length; i++)
    {
        
        if (min < arr[i]) min = arr[i];
        if (max > arr[i]) max = arr[i];
    }
    
    System.Console.WriteLine($"{max}; {min}");
    dif = max - min;
    return dif;
}

double[] FillArray(int size, int min = 0, int max = 100)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}