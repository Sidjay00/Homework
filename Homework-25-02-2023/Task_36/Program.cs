/* **Задача 36:** Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

int[] arr = FillArray(12);
int[] array = OddItemsFromArray(arr);
int sum = 0;

foreach (int item in array)
{
    sum += item;
}

System.Console.WriteLine($"[{String.Join(", ", arr)}] -> {sum}");


int[] OddItemsFromArray(int[] arr)
{
    int[] odds = new int[arr.Length / 2];
    int oddsItem = 0;
    for (int i = 1; i < arr.Length; i += 2)    // Условие задачи можно прочитать двояко, можно считать чётным каждый второй элемент массива, а также элементы массива согласно индексу. Для того, чтобы решить задачу для первого случая i должно быть равно 0, для второго - 1.
    {
        odds[oddsItem] = arr[i];
        oddsItem++;
    }
    return odds;
}

int[] FillArray(int size, int min = 0, int max = 10)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}