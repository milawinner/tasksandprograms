﻿// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое целое положительное число");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());

int SumOfAllNumbersBetween(int M, int N)
{
    if (M < N)
    {
        return SumOfAllNumbersBetween(M + 1, N) + M;
    }
    else if (M > N)
    {
        return SumOfAllNumbersBetween(N + 1, M) + N;
    }
    else 
    {
        return M;
    }
}
Console.Write("Сумма натуральных чисел между введёнными числами: ");
Console.WriteLine(SumOfAllNumbersBetween(M, N));