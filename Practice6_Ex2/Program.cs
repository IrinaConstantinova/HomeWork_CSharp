// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System.Reflection.Metadata;

double ReadNumbers(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void IntersectionPoint(double b1, double b2, double m1, double m2)
{
    double x;
    double y;

    x = (b2 - b1) / (m1 - m2);
    y = m1 * x+ b1;

    System.Console.WriteLine($"Точка пересечения прямых A и B: ({x} ; {y})");
}

double b1 = ReadNumbers("Введите точку пересесения прямой А с осью ординат b1 = ");
double k1 = ReadNumbers("Введите угловой коэффициент прямой А k1 = ");
double b2 = ReadNumbers("Введите точку пересесения прямой B с осью ординат b2 = ");
double k2 = ReadNumbers("Введите угловой коэффициент прямой B k2 = ");


IntersectionPoint(b1, b2, k1, k2);

