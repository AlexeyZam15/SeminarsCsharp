// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int remainder = number % 2;
Console.WriteLine("Является ли чесло чётным?");
if (remainder > 0) Console.WriteLine("нет");
else Console.WriteLine("да");