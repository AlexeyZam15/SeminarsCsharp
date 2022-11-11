// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
int remainder = 0;
Console.Write($"Чётные числа от 1 до {N}: ");
while (count <= N)
{
    remainder = count % 2;
    if (remainder == 0)
    {
        Console.Write($"{count} ");
    }
    count++;
}