//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//  645 -> 5

//  78 -> третьей цифры нет

//  32679 -> 6


Console.Write("ВВедите трeхзначное число: ");

int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 99 && Number < 10000)
{
    Number = Number % 10;
    Console.WriteLine(Number);
}

if (Number > 10000)
{
    Console.WriteLine(Number>99 ? Number.ToString()[2] : '-');
}
