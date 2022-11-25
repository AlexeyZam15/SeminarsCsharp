// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

void PrintArray(int[] arr, string beginStr, string endstr, string separatorElems)
{
    Console.Write(beginStr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}{separatorElems} ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(endstr);
}

int sizeArray = -1;
while (sizeArray <= 0)
{
    Console.Write("Введите размер массива: ");
    sizeArray = Convert.ToInt32(Console.ReadLine());
    if (sizeArray <= 0) Console.WriteLine("Введены неверные данные");
}

int[] array = CreateArrayRndInt(sizeArray, 100, 999);
PrintArray(array, "[", "]", ",");

int CountEvenArray(int[] arr)
{
    int count1 = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count1 += 1;
    }
    return count1;
}

int countEvenArray = CountEvenArray(array);
Console.WriteLine($" -> {countEvenArray}");
