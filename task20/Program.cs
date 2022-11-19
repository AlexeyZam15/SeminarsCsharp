// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.Write("Введите x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());


double Distance(int x11, int y11, int x22, int y22)
{
    return Math.Sqrt((x11-x22)*(x11-x22)+(y11-y22)*(y11-y22));
}

double distance = Math.Round(Distance(x1,y1,x2,y2),2,MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками = {distance}");