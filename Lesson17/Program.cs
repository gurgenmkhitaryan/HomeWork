
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



int[] GetArray(int size, int minRandom, int maxRandom)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++) // result.Length = size
    {
        result[i] = new Random().Next(minRandom, maxRandom + 1); // [-9;9]
    }
    return result;
}

Console.WriteLine("Введите размер массива ");
int LanArray = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray(LanArray, -99, 99);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");
Console.WriteLine($"Количество чисел болше 0 = {count}");