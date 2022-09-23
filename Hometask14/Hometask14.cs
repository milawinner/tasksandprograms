// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите кординаты первой прямой");
int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординаты второй прямой");
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

Console.WriteLine($"{y1}, {y2} - это координаты точки пересечения прямых");