// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int n = Convert.ToInt32(Console.ReadLine());

int[,] doubleArray = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        doubleArray[i, j] = new Random().Next(-100, 100);
        Console.Write($"{doubleArray[i, j]} ");
    }
    Console.WriteLine();
}