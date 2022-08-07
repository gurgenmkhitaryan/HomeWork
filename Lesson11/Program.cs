
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

while(true)
{
    Console.Write("Введите первое число: ");

    int ferstDigit = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите второе число: ");

    int secondDigit = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Math.Pow(ferstDigit, secondDigit));

}



