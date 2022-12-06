// Задача 20.
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату XA: ");
int XA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату YA: ");
int YA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату XB: ");
int XB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату YB: ");
int YB = int.Parse(Console.ReadLine()!);

double pif = Math.Sqrt((XB - XA)*(XB - XA) + (YB - YA)*(YB - YA));
double result = pif;
Console.WriteLine(result);
