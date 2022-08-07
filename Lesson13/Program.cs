// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int[] GetArray (int size, int minRandom, int maxRandom)
{
    int [] result = new int[size];
    for (int i = 0; i < result.Length; i++) // result.Length = size
    {
    result[i] = new Random().Next(minRandom,maxRandom + 1); // [-9;9]
    }
    return result;
}

int [] array = GetArray(8,0,99);
Console.WriteLine($"Результат: [ {String.Join("; ", array)} ]");

