// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7



int[,] FillSpiralArray(int n) 
{
    int[,] array = new int[n, n];

    int count = 1;

    int k = 0;

    while (count <= n * n && k <= n / 2)
    {

        for (int j = k; j < n - 1 - k; j++) // 1-я линия - движение вправо
        {
            array[k, j] = count;
            count++;
        }



        for (int i = k; i < n - 1 - k; i++) // 2-я линия - движение вниз
        {
            array[i, n - 1 - k] = count;
            count++;
        }



        for (int j = n - 1 - k; j > k; j--) // 3-я линия - движение влево
        {
            array[n - 1 - k, j] = count;
            count++;
        }



        for (int i = n - 1 - k; i > k; i--) // 4-я линия - движение вверх
        {
            array[i, k] = count;
            count++;
        }


        k++;

    }

    if (n % 2 != 0) array[n / 2, n / 2] = count;

    return array;
}

int[,] FillSpiralArray2() // не мое решение (нашел в интернете)
{
    int n = 4;
    int[,] sqareMatrix = new int[n, n];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
        sqareMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }

    return sqareMatrix;

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

Console.Write("Введите размер квадратной матрицы: ");

int size = Convert.ToInt32(Console.ReadLine());

int[,] myArray = FillSpiralArray(size);

PrintMatrix(myArray);