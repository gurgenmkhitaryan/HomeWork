// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



double [] array = new double[8];

double maxNumber = 0;

double minNumber = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 100;
}

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > maxNumber) maxNumber = array[i];
    
    else minNumber = array[i];

    
    
}

double result = maxNumber - minNumber;



Console.WriteLine(String.Join("; ", array));
Console.WriteLine($" Разницу между максимальным и минимальным элементов {result}");
