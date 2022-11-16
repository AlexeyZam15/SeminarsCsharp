// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int day = -1;

while (day < 1 || day > 7)
{
    Console.Write("Введите номер дня недели: ");
    day = Convert.ToInt32(Console.ReadLine());
    if (day < 1 || day > 7) Console.WriteLine("Введено неверное значение");
}

bool DayOff(int day1)
{
    return day1 == 6 || day1 == 7;
}

Console.WriteLine("Является ли этот день выходным?");
Console.WriteLine(DayOff(day) ? "да" : "нет");