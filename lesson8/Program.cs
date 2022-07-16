// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("ВВедите  число ");

int Number = Convert.ToInt32(Console.ReadLine());

int Num1 = Number / 10000;

int Num2 = (Number / 1000) % 10;

int Num4 = (Number % 100) / 10;

int Num5 = Number % 10;

if (Num1 == Num5 && Num2 == Num4) Console.WriteLine("Да ");
else Console.WriteLine("Нет ");