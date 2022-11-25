// Задача 31: 
// 1. Задайте массив из 12 элементов, 
// 2. заполненный случайными числами из промежутка [-9, 9]. 
// 3. Вывести массив в консоль
// 4. Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SumNegativeElemsArray(int[] arr)
{
    int sumNegative1 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sumNegative1 += arr[i];
    }
    return sumNegative1;
}

int SumPositiveElemsArray(int[] arr)
{
    int sumPositive1 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumPositive1 += arr[i];
    }
    return sumPositive1;
}

int[] array = CreateArrayRndInt(12, -9, 9);

PrintArray(array);

int sumNegative = SumNegativeElemsArray(array);
int sumPositive = SumPositiveElemsArray(array);
Console.WriteLine($"Сумма положительных чисел = {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел = {sumNegative}");