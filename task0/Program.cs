// Задача 0 Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдаёт его квадрат (число умноженное на само себя).
Console.Clear();
Console.WriteLine("Введите целое число");
int numb = Convert.ToInt32(Console.ReadLine());
int square = numb * numb;
Console.WriteLine($"Квадрат числа {numb} = {square}");