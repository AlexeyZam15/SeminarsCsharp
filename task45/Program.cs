// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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

void PrintArray(int[] arr, string beginStr, string separatorElems, string endstr)
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

int[] array = CreateArrayRndInt(5,1,9);
PrintArray(array,""," ","");

int[] CopyArray(int[] arr)
{
    int[] arrCopy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrCopy[i]=arr[i];
    }
    return arrCopy;
}

int[] arrayCopy = CopyArray(array);
PrintArray(arrayCopy,@"
"," ","");