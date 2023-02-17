Console.Write("Введите целое число: ");
int N;
int.TryParse(Console.ReadLine(), out N);

for (int i = 2; i <= N; i += 2)
{
    Console.WriteLine($"{i}");
}
