// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите любое целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1) Console.WriteLine("Шалун! Надо было ввести целое положительное число!");

void PrintNumbersFromOneToN(int N)
{
    Console.Write($"{N} ");
    if (N > 1)
    {
        PrintNumbersFromOneToN(N-1);
    }
}
PrintNumbersFromOneToN(N);
