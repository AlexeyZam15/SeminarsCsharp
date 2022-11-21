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

// int Reverse(int numb)
// {
//     int firstDigit = numb / 10000;
//     int secondDigit = numb % 10000 / 1000;
//     int thirdDigit = numb % 1000 / 100;
//     int fourthDigit = numb % 100 / 10;
//     int fifthDigit = numb % 10;
//     return fifthDigit * 10000 + fourthDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + firstDigit;
// }

int Reverse(int numb, int digits)
{
    int result = 0;
    int length = 1;
    for (int i = 1; i < digits; i++)
    {
        length = length * 10;
    }
    for (int j = 1; j <= length; j = j * 10)
    {
        result = result + numb / (length / j) * j;
        numb = numb % (length / j);
    }
    // for (int j = 10000; j != 1; j = j / 10) // 12345
    // {
    //     result = result + numb % 10 * j; // 50000 // 4000 // 300
    //     numb = numb / 10; // 1234 // 123 //
    // }
    // result = result + numb;
    return result;
}

int reverse = Reverse(number, 5);
Console.WriteLine($"Обратное число: {reverse}");
Console.WriteLine("Является ли число палиндромом?");
Console.WriteLine(number == reverse ? "да" : "нет");