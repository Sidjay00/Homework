/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */


string ConsoleTakeInt()
{
	int number;
	Console.Write($"Введите пятизначное число: ");
	bool flag = int.TryParse(Console.ReadLine(), out number);
	if (flag = false)
    	{
            return number;
            Console.Write($"{number}");
        }
	else
	{
    	string text = number.ToString();
        int i = 4;
        if (i = text.Length)
        {
            return text;
        }
        else
    	{
            return ConsoleTakeInt();
        }
	}
}


// Console.Write("Введите пятизначное число: ");
// bool flag = int.TryParse(Console.ReadLine(), out number);
// 	if (flag = false)
//     	return Console.Write($"YtdthyВведено пятизначное число: ");
// 	else
// 	{
    	
//     	return ConsoleTakeInt();
// 	}


/* void PrintArray(int[] array)
{
	int count = array.Length;
	for (int i = 0; i < count; i++)
	{
    	Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
} */

// text = number.ToString();
// Console.WriteLine(number is String); 

// void TurnOver(int array)
// {
// 	for( int i = 0; i < array.Length; i++)
// 	{
//     	int minPosition = i;
//     	for (int j = i + 1; j < array.Length; j++)
//     	{
//         	if (array[j] < array[minPosition]) minPosition = j;
//     	}
//     	int temporary = array[i];
//     	array[i] = array[minPosition];
//     	array[minPosition] = temporary;
// 	}
// }

// PrintArray(arr);
// Sort(arr);
// PrintArray(arr);
