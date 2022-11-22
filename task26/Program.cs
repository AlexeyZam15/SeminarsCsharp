// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CountDigits(int numb)
{
    if (numb < 0) numb = numb * -1;
    int count = 1;
    while (numb > 9)
    {
        count++;
        numb = numb / 10;
    }
    return count;
}

int countDigits = CountDigits(number);
Console.WriteLine($"Количество цифр в числе: {countDigits}");