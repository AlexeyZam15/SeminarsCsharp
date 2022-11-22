// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int numb)
{
    int sum = 0;
    if (numb < 0) numb = numb * -1;
    while (numb > 0)
    {
        sum = sum + numb % 10;
        numb = numb / 10;
    }
    return sum;
}
int sumDigits = SumDigits(number);
Console.WriteLine(sumDigits);