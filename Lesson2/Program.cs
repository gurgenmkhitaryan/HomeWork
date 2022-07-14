//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22

Console.Write("ВВедите первое число: ");

int FiorstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("ВВедите второе число: ");

int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("ВВедите третье число: ");

int ThirdNumber = Convert.ToInt32(Console.ReadLine());



if (FiorstNumber > SecondNumber && FiorstNumber > ThirdNumber)
{
    Console.Write(FiorstNumber + " максимальное ");
}
else if (SecondNumber > FiorstNumber && SecondNumber > ThirdNumber)
{
    Console.Write(SecondNumber + " максимальное ");
}
else
{
   Console.Write(ThirdNumber + " максимальное "); 
}