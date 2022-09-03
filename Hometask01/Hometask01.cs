// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.


Console.Clear();
Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999)
{
    Console.WriteLine("Ошибка ввода! Введите трёхзначное число!");
}
else
{
    int secondNum = (num % 100);
    int finalNum = (secondNum / 10); 
    Console.WriteLine($"{finalNum} - это вторая цифра этого числа");
}