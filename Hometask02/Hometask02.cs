// Задача 13: Напишите программу, которая выводит третью цифру слева (на самом деле СПРАВА) 
//заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите любое число");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 99)
{
    Console.WriteLine($"У числа {num} нет третьей цифры");
}
while (num > 999)
{
    num = num / 10;
}
int SecretNum = num % 10; 
Console.WriteLine($"{SecretNum} - это третья цифра этого числа");
