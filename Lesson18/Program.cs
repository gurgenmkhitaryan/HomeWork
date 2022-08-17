// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 

// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// k1 * x + b1 = k2 * x + b2 = y

// x  = (b2 — b1) / (k1 — k2);


Console.WriteLine("Введите координат b1");

int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координат k1");

int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координат b2");

int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координат k2");

int k2 = Convert.ToInt32(Console.ReadLine());



double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;
Console.WriteLine($"{x} {y}");


