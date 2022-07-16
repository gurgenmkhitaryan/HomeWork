//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//  6 -> да

//  7 -> да

//  1 -> не


Console.Write("ВВедите  день: ");

int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 0 && Number < 8)
{
    if (Number == 6 || Number == 7)
    {
        Console.WriteLine("Да: ");
    }
    else 
    {
        Console.WriteLine("Нет: ");
    }
}
else
{
    Console.Write("День введен не правильно! ");
}