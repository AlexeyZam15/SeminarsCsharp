﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int numberB = 0;
while (numberB <= 0)
{
    Console.Write("Введите натуральное число B: ");
    numberB = Convert.ToInt32(Console.ReadLine());
    if (numberB <= 0) Console.WriteLine("Введены неверные данные");
}

int Degree(int numbA, int numbB)
{
    int numbAB = numbA;
    for (int i = 1; i < numbB; i++)
    {
        numbAB = numbAB * numbA;
    }
    return numbAB;
}

int numberAB = Degree(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = {numberAB}");