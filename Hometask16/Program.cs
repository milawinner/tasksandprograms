// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк в массиве");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int b = Convert.ToInt32(Console.ReadLine());

int[,] doubleArray = new int[a, b];
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        doubleArray[i, j] = new Random().Next(-30, 30);
        Console.Write($"{doubleArray[i, j]} ");
    }
    Console.WriteLine();
}

void ElementPosition (int [,] doubleArray)
{
    Console.WriteLine("Укажите номер строки:");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Укажите номер столбца:");
    int d = Convert.ToInt32(Console.ReadLine());
    if (c < doubleArray.GetLength(0) & d < doubleArray.GetLength(0)) 
    {
        Console.WriteLine($"Этот элемент имеет следующее значение: {doubleArray[c,d]} ");
    }
    else Console.WriteLine("Такого элемента нет в этом массиве.");
}
ElementPosition(doubleArray);
