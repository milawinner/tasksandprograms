// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов 
// в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк в массиве:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int b = Convert.ToInt32(Console.ReadLine());

int[,] doubleArray = new int[a, b];
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        doubleArray[i, j] = new Random().Next(0, 10);
        Console.Write($"{doubleArray[i, j]} ");
    }
    Console.WriteLine();
}

void TheSmallestRaw (int [,] array) 
{
    int minSum = 0;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        minSum+=array[0, k];
    }
    int minSumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowNumsSum = 0;
        for( int j = 0; j < array.GetLength(1); j++)
        {
            rowNumsSum += array[i, j];
            
        }
        if (rowNumsSum < minSum)
        {
            minSum = rowNumsSum;
            minSumRow = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов содержится в строке номер {minSumRow + 1}");
}

TheSmallestRaw(doubleArray);