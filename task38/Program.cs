// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr, string beginStr, string endstr, string separator)
{
    Console.Write(beginStr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}{separator} ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(endstr);
}

double MinArrayDouble(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double MaxArrayDouble(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double[] array = CreateArrayRndDouble(5, 0, 100);
PrintArrayDouble(array, "[", "]", "");

double minArrayDouble = MinArrayDouble(array);
double maxArrayDouble = MaxArrayDouble(array);
double subtractMaxMinArray = Math.Round(maxArrayDouble - minArrayDouble,1);

Console.WriteLine($" -> {subtractMaxMinArray}");