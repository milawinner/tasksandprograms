// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

Console.WriteLine("Сколько элементов вы хотите видеть в массиве?");
int size = Convert.ToInt32(Console.ReadLine());

int[] massiv = new int[size];
int count = 0;
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = new Random().Next(100, 1000);
    Console.Write($" {massiv[i]} ");
    if (massiv[i] % 2 == 0)
    {
    count++;
    }
}
Console.WriteLine ();
Console.WriteLine($"Количество чётных чисел в массиве: {count}");