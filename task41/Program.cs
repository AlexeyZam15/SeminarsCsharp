// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void PrintArray(int[] arr, string beginStr, string separatorElems, string endStr)
{
    Console.Write(beginStr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}{separatorElems}");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(endStr);
}

int[] StringToNumbersArray(string str, int amountNumbers)
{
    int[] arr = new int[amountNumbers];
    string number = string.Empty;
    int indexArray = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != ',')
        {
            number += str[i];
        }
        if (str[i] == ',')
        {
            arr[indexArray] = Convert.ToInt32(number);
            number = string.Empty;
            indexArray++;
        }
        if (i == str.Length - 1)
        {
            arr[indexArray] = Convert.ToInt32(number);
            number = string.Empty;
            indexArray++;
        }
    }
    return arr;
}

int AmountNumbersAboveZeroArray(int[] arr)
{
    int amount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) amount++;
    }
    return amount;
}

Console.Write("Введите количество чисел для ввода: ");
int m = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[m];
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите {i+1}-ое число: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

Console.Write($"Введите {m} целых чисел через запятую: ");
string numbersString = Console.ReadLine();

int[] array = StringToNumbersArray(numbersString, m);

int amountNumbersAboveZeroArray = AmountNumbersAboveZeroArray(array);
PrintArray(array, "", ", ", $" -> {amountNumbersAboveZeroArray}");