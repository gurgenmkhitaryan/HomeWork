// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



/// new array with random elements
int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintMatrix(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
}
int[] GetSumArray(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumArray[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray[i] += array[i, j];
        }
    }
    return sumArray;
}
int FindLineWithMinSum(int[] array)
{
    int minRowIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minRowIndex]) minRowIndex = i;
    }
    return minRowIndex;
}
Console.WriteLine("Введите число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateMatrix(rows, columns, min, max);
PrintMatrix(myArray);
int[] sumArray = GetSumArray(myArray);
Console.Write("Суммы по строкам равны: ");
PrintArray(sumArray);
int minLineIndex = FindLineWithMinSum(sumArray);
Console.WriteLine();
Console.Write("Номер строки с минимальной суммой: " + minLineIndex);


//Console.WriteLine($"Индекс строки с минимальной суммой: {minLineSumIndex}");