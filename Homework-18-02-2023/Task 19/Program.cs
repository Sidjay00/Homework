/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */


// int number;
// Console.Write("Введите пятизначное число: ");
// int.TryParse(Console.ReadLine(), out number);

string ConsoleTakeString()
{
	int number;
	Console.Write($"Введите число: ");
	bool flag = int.TryParse(Console.ReadLine(), out number);
	if (flag)
    {
    	string text = number.ToString();
		int i = 5; // данная переменная задана для проверки количества знаков в числе. т.к. по условию задачи число должно быть 5-значным, поэтому здесь стоит 5.
		int length = text.Length;
		if (i == length)
		{
		    return text;
		}
		else
		{
		    Console.WriteLine("Введено не пятизначное число!!");
		    return ConsoleTakeString();
		}			
    }    
	else
	{
    	Console.Write($"Введено не число\n");
    	return ConsoleTakeString();
    }
}



Console.WriteLine(text);
