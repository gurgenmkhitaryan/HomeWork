﻿//  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3

Console.Write("ВВедите первое число: ");

int FiorstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("ВВедите второе число: ");

int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (FiorstNumber > SecondNumber)
{
    Console.Write(FiorstNumber + " больше " + SecondNumber);
}
else
{
    Console.Write(SecondNumber + " больше " + FiorstNumber);
}









