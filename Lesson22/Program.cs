// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8



/// new array
int[,] GetArray(int n, int m, int min, int max)
{
    int[,] result = new int[m, n];
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = new Random().Next(min, max + 1);
            }
        }
    }
    return result;
}

/// print array
void PrintArray(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write(myArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] SortRowElementsFromMinToMax(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            int minIndex = k;
            
            for (int j = k + 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] < array[i,minIndex]) minIndex = j;
            }
            if (minIndex != k)
            {
                int temp = array[i, k];
                array[i, k] = array[i, minIndex];
                array[i, minIndex] = temp;
            }
        }
    }
    return array;
}


Console.WriteLine("Введите число строк массива: ");

int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов массива: ");

int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);

int[,] myArray = SortRowElementsFromMinToMax(array);

Console.WriteLine("Массив после сортировки: ");

PrintArray(myArray);

Console.WriteLine(array);