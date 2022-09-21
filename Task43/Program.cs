/*
Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


/*
x=b2-b1/k1-k2
y = k2 * x + b2


x=4-2/5-9       2/-4  -0.5
y = k2 * x + b2     -4.5+4  -0.5

*/
Console.WriteLine("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double x,y;
x=(b2-b1)/(k1-k2);
y = (k2*x) + b2;
Console.WriteLine($"Точка пересечения ({x}, {y}). ");
