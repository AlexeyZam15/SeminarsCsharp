// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.Write("Введите первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int b = Convert.ToInt32(Console.ReadLine());
void Multiple(int numb1, int numb2)
{
    if (numb1 % numb2 == 0)
    {
        Console.WriteLine($"Число {numb1} является кратным числу {numb2}");
    }
    else
    {
        Console.WriteLine($"Число {numb1} не является кратным числу {numb2}");
        Console.WriteLine($"Остаток от деления {numb1} на число {numb2} = {numb1 % numb2}");
    }
}

Multiple(a, b);