/* **Задача 50:** Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа (???) элемента, наверно? в массиве нет */


double[,] array = new double[3, 4];
for (int i = 0; i < array.GetLength(0); i++) 
    for (int j = 0; j < array.GetLength(1); j++) 
        array[i, j] = new Random().Next(0, 10);

int[] index = ValueInput();
PrintArray(array);
if (index[0] >= 0 && index[0] < array.GetLength(0) && index[1] >= 0 && index[1] < array.GetLength(1))
    System.Console.WriteLine($"Элемент array[{index[0]}, {index[1]}] равен {array[index[0], index[1]]}");
else
{
    System.Console.WriteLine($"Элемента array[{index[0]}, {index[1]}] в данном массиве нет!");
}


int[] ValueInput()
{
    int[] ElementPosition = new int[2];
    for (int i = 0; i < ElementPosition.GetLength(0); i++)
    {
        System.Console.Write("Введите по очереди номер строки и номер столбца элемента: ");
        int.TryParse(Console.ReadLine(), out ElementPosition[i]);
    }
    return ElementPosition;
}

void PrintArray(Array arr) //Задаем функцию для печати массивов: одномерного, двухмерного и трехмерного. В скобочках обозначается, что на ввод берется массив Array <имя переменной>
{
    switch (arr.Rank)   // Новый метод switch, не помню, когда нам его давали, но похоже он просто переключает внутри себя, когда определяет, по какому case надо работать. .Rank - определяет размер массива, как я понял.
    {
        case 1:
            for (int i = 0; i < arr.GetLength(0); i++) // Строка одномерного массива
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