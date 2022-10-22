// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите  b1 = ");
float b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  k1 = ");
float k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  b2 = ");
float b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите  k2 = ");
float k2 = int.Parse(Console.ReadLine());

float Spotx = 0;
float Spoty = 0;

Spotx = ((b2 - b1) / (k1 - k2));
Spoty = (k1 * ((b2 - b1) / (k1 - k2)) + b1);

Console.WriteLine($"Точка персечения прямых ({Spotx};{Spoty})");