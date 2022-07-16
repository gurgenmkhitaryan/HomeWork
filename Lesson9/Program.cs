// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координат x1");

int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координат y1");

int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координат z1");

int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координат x2");

int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координат y2");

int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координат z2");

int z2 = Convert.ToInt32(Console.ReadLine());



var result = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));

Console.WriteLine(result);