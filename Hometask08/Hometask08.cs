// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите любое число");
int num = Convert.ToInt32(Console.ReadLine());
int sumnum = 0;
while (num > 0) 
{
    sumnum = sumnum + num % 10;
    num /= 10;
} 

Console.WriteLine($"{sumnum} - это сумма цифр во введённом числе");