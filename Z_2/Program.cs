//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("Введите точку b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите точку k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите точку b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите точку k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double PoiskX(double arg1, double arg2, double arg3, double arg4)
{
    double x = ((arg3 - arg1) / (arg2 - arg4));
    return x;
}
double PoiskY(double arg1, double arg2, double arg3)
{
    double y = arg1 * arg2 + arg3;
    return y;
}
if((b1/b2)!=(k1/k2))
{
    Console.Write($"Точка пересечения двух прямых -> ({PoiskX(b1, k1, b2, k2)};");
    Console.Write($"{PoiskY(k1, PoiskX(b1, k1, b2, k2), b1)})");
}
else 
{
    Console.Write("Прямые параллельны либо не совпадают.");
}