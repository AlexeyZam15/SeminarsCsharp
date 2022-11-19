// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = -1;
while (number < 10000 || number > 99999)
{
    Console.Write("Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number < 0 || number < 10000 || number > 99999) Console.WriteLine("Введены неверные данные");
}

int Reverse(int numb)
{
    int firstDigit = numb / 10000;
    int secondDigit = numb % 10000 / 1000;
    int thirdDigit = numb % 1000 / 100;
    int fourthDigit = numb % 100 / 10;
    int fifthDigit = numb % 10;
    return fifthDigit * 10000 + fourthDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + firstDigit;
}

int reverse = Reverse(number);
Console.WriteLine($"Обратное число: {reverse}");
Console.WriteLine("Является ли число палиндромом?");
Console.WriteLine(number == reverse ? "да" : "нет");