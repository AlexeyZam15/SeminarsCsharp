// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1
int number = -1;
while (number < 99 || number > 999)
{
    Console.Write("Введите трёхзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 99 || number > 999) Console.WriteLine("Введено неверное значение");
}

int SecondDigit(int numb)
{
    return numb % 100 / 10;
}

Console.WriteLine($"Вторая цифра числа - {SecondDigit(number)}");