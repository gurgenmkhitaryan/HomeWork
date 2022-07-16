//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//  456 -> 5

//  782 -> 8

//  918 -> 1

Console.Write("ВВедите трeхзначное число: ");

int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 99 && Number < 1000)
{
    int FerstDigit = Number % 100; 

    int LestDigit = FerstDigit / 10; 

    Console.WriteLine(LestDigit);
}
else
{
    Console.Write("Число не трeхзначное ");
}