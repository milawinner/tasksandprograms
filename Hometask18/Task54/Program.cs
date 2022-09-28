// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int [,] SortedArray (int [,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            for (int k = j; k < doubleArray.GetLength(1); k++)
            {
                if (doubleArray[i, k] > doubleArray[i, j])
                {
                    int help = doubleArray[i, k];
                    doubleArray[i, k] = doubleArray[i, j];
                    doubleArray[i, j] = help;
                }
            } 
        }
    }
    return doubleArray;
}
void PrintArray (int [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        } 
        Console.WriteLine();
    }
    
}
int [,] anotherArray = SortedArray(doubleArray);
Console.WriteLine("Отсортированный по строкам массив:");
PrintArray (anotherArray);