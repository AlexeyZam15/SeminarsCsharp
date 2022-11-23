// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

void RandomArray(int[] array1, int min1, int max1)
{
    Random rnd = new Random();
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = rnd.Next(min1, max1);
    }
}

void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
}

RandomArray(array, 0, 100);

// Console.WriteLine(string.Join(" ", array));
PrintArray(array);