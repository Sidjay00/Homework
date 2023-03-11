/* **Задача 38:** Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double[] arr = FillArray(12, -100, 100);


// System.Console.WriteLine($"[{String.Join(", ", arr)}]");

double[] FillArray(int size, int min = 0, int max = 100)
{
double[] arr = new double[size];
for (int i = 0; i < size; i++)
    arr[i] = new Random().Next(min, max);
return arr;
}

System.Console.WriteLine($"[{String.Join(", ", arr)}]");


// double[] FillArray(int size, double min = 0, double max = 100)
// {
//     double[] arr = new int[size];
//     for (double i = 0; i < size; i++)
//         arr[i] = new Random().Next(min, max);
//     return arr;
// }