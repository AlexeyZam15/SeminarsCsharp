// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int numb, int numb1, int numb2)
{
    return numb % numb1 == 0 && numb % numb2 == 0; // true или false возвращает
}
Console.WriteLine(Multiplicity(number, 7, 23) ? $"Число {number} кратно 7 и 23" : $"Число {number} не кратно 7 и 23");