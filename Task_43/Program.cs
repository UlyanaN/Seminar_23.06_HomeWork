// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задайте два прямых отрезка");
Console.WriteLine("Значение 1 первого отрезка: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Значение 2 первого отрезка: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Значение 1 второго отрезка: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Значение 2 второго отрезка: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double InserDirecX (double num11, double num12, double num21, double num22)
{
    double x = (num21 - num11) / (num12 - num22);
    return (x);
}
double InserDirecY (double num11, double num12, double numX)
{
double y = num12 * numX + num11;
return (y);
}
double resX = InserDirecX (b1, k1, b2, k2);
double resY = InserDirecY (b1, k1, resX);
Console.WriteLine ("Точка пересечения 2х прямых: ");
Console.WriteLine (resX);
Console.WriteLine (resY);