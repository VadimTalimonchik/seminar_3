﻿// Задача №17. 
// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причем X ≠ 0 и Y ≠ 0
// и выдаёт номер четверти плоскости, в которой
// находится эта точка.

// Console.Write("Введите координату X: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координату y: ");
// int y = int.Parse(Console.ReadLine()!);

// if(x > 0 && y > 0)
// {
//     Console.WriteLine("Первая четверть.");
// }

// if(x < 0 && y > 0)
// {
//     Console.WriteLine("Вторая четверть.");
// }

// if(x < 0 && y < 0)
// {
//     Console.WriteLine("Третья четверть.");
// }

// if(x > 0 && y < 0)
// {
//     Console.WriteLine("Четвёртая четверть.");
// }

Console.Write("Введите координату X: ");
int X = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y: ");
int Y = int.Parse(Console.ReadLine()!);

if (X > 0 && Y > 0) Console.WriteLine("Первая четверть");
if (X < 0 && Y > 0) Console.WriteLine("Вторыя четверть");
if (X < 0 && Y < 0) Console.WriteLine("Третья четверть");
if (X > 0 && Y < 0) Console.WriteLine("Четвёртая четверть");
