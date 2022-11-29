// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int Fibonacci(int n)
// {
//     return (n == 0 || n == 1 || n == 2) ? 1 : Fibonacci(n - 1) + Fibonacci(n - 2);
// }

void PrintArray(int[] arr, string beginStr, string separatorElems, string endstr)
{
    Console.Write(beginStr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}{separatorElems}");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(endstr);
}

int[] Fibonacci(int numb)
{
    int[] arr = new int[numb];
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
    }
    return arr;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] fibonacci = Fibonacci(number);

PrintArray(fibonacci, ""," ","");