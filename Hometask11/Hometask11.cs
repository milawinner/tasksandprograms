// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Сколько элементов должно быть в будущем массиве?");
int size = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[size];
int sum = 0;
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = new Random().Next(-100, 101);
    Console.Write($" {massiv[i]} ");
     if (i % 2 > 0)
        {
            sum += massiv[i];
        }
} 

Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");
