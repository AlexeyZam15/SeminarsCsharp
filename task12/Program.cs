// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Введите первое число - ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число - ");
// int b = Convert.ToInt32(Console.ReadLine());
// void Multiple(int numb1, int numb2)
// {
//     if (numb1 % numb2 == 0)
//     {
//         Console.WriteLine($"Число {numb1} является кратным числу {numb2}");
//     }
//     else
//     {
//         Console.WriteLine($"Число {numb1} не является кратным числу {numb2}");
//         Console.WriteLine($"Остаток от деления {numb1} на число {numb2} = {numb1 % numb2}");
//     }
// }

// Multiple(a, b);

Console.Write("Введите первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int b = Convert.ToInt32(Console.ReadLine());

// bool Multiplicity(int number1, int number2)
// {
//     return number1 % number2 == 0;
// }

int MultiplicitySecond(int number1, int number2)
{
    return number1 % number2;
}

// bool result = Multiplicity(a,b);
// Console.WriteLine(result ? "Первое число кратно второму" : $"Некратно, остаток = {a % b}");

int result2 = MultiplicitySecond(a,b);
Console.WriteLine(result2 == 0 ? "Первое число кратно второму" : $"Некратно, остаток = {result2}");
