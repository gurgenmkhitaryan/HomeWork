// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int summ = 0;

for (int i = 1; i < array.Length; i+=2)
{
    summ = summ + array[i];
}

Console.WriteLine($"Результат: [ {String.Join("; ", array)} ]");
Console.WriteLine($"Сумма нечётных позиции {summ}");