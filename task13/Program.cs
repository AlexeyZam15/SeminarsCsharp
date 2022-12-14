// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int numb)
{
    numb = numb < 0 ? numb * -1 : numb;
    while (numb > 999 ) numb = numb / 10;
    return numb < 100 ? -1 : numb % 10;
}
int thirdDigit = ThirdDigit(number);
Console.WriteLine(thirdDigit == -1 ? "Третьей цифры нет" : $"Третья цифра числа - {thirdDigit}");