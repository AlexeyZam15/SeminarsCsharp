// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] array = CreateArrayRndInt(sizeArray, -99, 99);
PrintArray(array, "[", "]", ",");

int SumOddIndexArray(int[] arr)
{
    int sumOdd = 0; 
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sumOdd += arr[i];
    }
    return sumOdd;
}

int sumOddArray = SumOddIndexArray(array);
Console.WriteLine($" -> {sumOddArray}");