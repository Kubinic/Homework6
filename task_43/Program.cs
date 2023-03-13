/*Задача43 Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите значения k1"); 
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значения b1"); 
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значения k2"); 
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значения b2"); 
double b2 = double.Parse(Console.ReadLine()!);
CrossingPoint(k1, b1, k2, b2);
void CrossingPoint(double k1, double b1,double k2, double b2)
{double x = (b2 - b1) / (-k2 + k1);
double y = (k2 * x) + b2;
if (x == y){
    Console.Write($"точка пересечения двух прямыхy (X {x}; Y {x})");
}
else{
    Console.Write("Прямые с заданым значением не пересикаются!");
}
}
