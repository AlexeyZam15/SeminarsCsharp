// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] StringToNumbersArray(string str, int amountNumbers)
{
    double[] arr = new double[amountNumbers];
    string number = string.Empty;
    int indexArray = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] != ',')
        {
            number += str[i];
        }
        if (str[i] == ',')
        {
            arr[indexArray] = Convert.ToDouble(number);
            number = string.Empty;
            indexArray++;
        }
        if (i == str.Length - 1)
        {
            arr[indexArray] = Convert.ToDouble(number);
            number = string.Empty;
            indexArray++;
        }
    }
    return arr;
}

double EquationX(double b1, double k1, double b2, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    return x;
}

double EquationY(double b1, double k1, double b2, double k2)
{
    double y = k2 * (-(b1 - b2) / (k1 - k2)) + b2;
    return y;
}

Console.Write($"Введите значения b1, k1, b2 и k2 через запятую: ");
string numbersString = Console.ReadLine();

double[] array = StringToNumbersArray(numbersString, 4);

double equationX = Math.Round(EquationX(array[0], array[1], array[2], array[3]),1);
double equationY = Math.Round(EquationY(array[0], array[1], array[2], array[3]),1);
Console.WriteLine($"b1 = {array[0]}, k1 = {array[1]}, b2 = {array[2]}, k2 = {array[3]} -> ({equationX}; {equationY})");