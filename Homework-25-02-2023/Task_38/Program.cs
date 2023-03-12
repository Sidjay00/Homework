/* **Задача 38:** Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

// /home/sysadmin/Dev/GeekBrains/Homework/Homework-25-02-2023/Task_38/Program.cs(11,8): error CS0161: 
// "MaxMinDif(double[])": не все пути к коду возвращают значение. 
// [/home/sysadmin/Dev/GeekBrains/Homework/Homework-25-02-2023/Task_38/Task_38.csproj]
// периодически возникает такая ошибка - это происходит из-за того, что я return ставлю внутри цикла for. NB!

double[] arr = FillArray(12, 0, 1000);

System.Console.WriteLine($"[{String.Join(", ", arr)}] -> {MaxMinDif(arr)}");

double MaxMinDif(double[] array)
{
    double min = array[0];
    double max = array[0];
    double dif = 0;

    foreach (double item in arr)
    {
        // if (item < min) min = item; 
        min = item < min ? item : min;  //заменил ифы на тернарный оператор
        // if (item > max) max = item;
        max = item > max ? item : max;
    }
    // for (int i = 1; i < array.Length; i++) - сначала решил задачу через for, затем заменил на foreach
    // {
        
    //     if (array[i] < min) min = array[i];
    //     if (array[i] > max) max = array[i];
    // }
    
    // System.Console.WriteLine($"{max}; {min}"); // создал эту строку для проверки вычисления максимума и минимума
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