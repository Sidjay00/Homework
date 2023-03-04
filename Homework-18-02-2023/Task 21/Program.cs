/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

double[] A = new double[3];
double[] B = new double[3];

Console.Write($"Введите координату x точки А: ");
double.TryParse(Console.ReadLine(), out A[0]);
Console.Write($"Введите координату y точки А: ");
double.TryParse(Console.ReadLine(), out A[1]);
Console.Write($"Введите координату z точки A: ");
double.TryParse(Console.ReadLine(), out A[2]);
Console.Write($"Введите координату x точки B: ");
double.TryParse(Console.ReadLine(), out B[0]);
Console.Write($"Введите координату y точки B: ");
double.TryParse(Console.ReadLine(), out B[1]);
Console.Write($"Введите координату z точки B: ");
double.TryParse(Console.ReadLine(), out B[2]);

double ans = Math.Round(Math.Sqrt(Math.Pow(A[0] - B[0], 2) + Math.Pow(A[1] - B[1], 2) + Math.Pow(A[2] - B[2], 2)), 3);

System.Console.WriteLine($"A({A[0]};{A[1]};{A[2]}) B({B[0]};{B[1]};{B[2]}) -> {ans}");