// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Сколько элементов должно быть в массиве?");
int size = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int [size];
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = new Random().Next(0, 100);
    Console.Write($" {massiv[i]} ");
} 
int min = massiv[0];
int max = massiv[0];
for (int i = 1; i < massiv.Length; i++)
{
    if (massiv[i] < min) min = massiv[i];
    else if (massiv[i] > max) max = massiv[i];
}
int diff = max - min;
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {diff}");
