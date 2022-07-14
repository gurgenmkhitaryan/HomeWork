

//  Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//  5 -> 2, 4
//  8 -> 2, 4, 6, 8



Console.Write("ВВедите число: ");

int Number = Convert.ToInt32(Console.ReadLine());

int Count = 1;

while (Count < Number)
{
    Count += 1;
    if (Count % 2 == 0)
    {
        Console.WriteLine(Count);
    }

}