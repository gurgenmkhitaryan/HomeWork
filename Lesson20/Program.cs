// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


/// new array with random elements
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);

        }

    }
    return result;
}

/// print array 
void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


// find value in array 
int FindArrayElementByIndex(int[,] array, int a, int b)
{
    if (array.GetLength(0) > a && array.GetLength(1) > b)
    {
        int result = array[a, b];
        Console.WriteLine($"Значение элемента с индексом ({a},{b}): {result}");
        return result;
    }
    else
    {
        Console.WriteLine("В массиве нет такого элемента!");
        return -1;
    }


}



Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] myArray = GetArray(rows, columns, 0, 10);

PrintArray(myArray);

Console.Write("Введите индекс элемента массива (через запятую): ");

string elementIndex = Console.ReadLine();

string [] elementIndexArray = elementIndex.Split(',');

int rowIndex = Int32.Parse(elementIndexArray[0]);

int columnIndex = Int32.Parse(elementIndexArray[1]);

FindArrayElementByIndex(myArray, rowIndex, columnIndex);



