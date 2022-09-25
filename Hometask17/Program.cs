// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк в массиве");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int b = Convert.ToInt32(Console.ReadLine());

int[,] doubleArray = new int[a, b];
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        doubleArray[i, j] = new Random().Next(0, 30);
        Console.Write($"{doubleArray[i, j]} ");
    }
    Console.WriteLine();
}
double middlePos = 0;
for (int i = 0; i < doubleArray.GetLength(1); i++)
{
    for (int j = 0; i < doubleArray.GetLength(0); j++)
    {
       middlePos = doubleArray[j, i] / a;
    }
    Console.Write(middlePos);
}
Console.WriteLine();