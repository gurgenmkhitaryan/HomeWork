// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3




/// new array with random elements
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(min, max + 1);

        }

    }
    return result;
}

/// print array 
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}



double[] GetColumnsArithmeticMean(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    double[] newArray = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double arithmeticMean = 0;

        for (int i = 0; i < rows; i++)
        {

            arithmeticMean += array[i, j];
        }
        newArray[j] = Math.Round(arithmeticMean / rows, 2);
    }

    return newArray;
}



Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
Console.WriteLine();

PrintArray(array);

double [] myArray2 = GetColumnsArithmeticMean(array);

Console.Write("Среднее арифметическое каждого столбца: ");

PrintArray(myArray2);