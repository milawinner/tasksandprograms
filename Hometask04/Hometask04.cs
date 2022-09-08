// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// int inversNum = 0;
// Console.Write(num % 10);
// while ((num /= 10) != 0) 
// {
//     Console.Write(num % 10);
// }

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int inversNum = num % 10;
Console.Write(inversNum);
while ((num /= 10) != 0) 
{
    inversNum = num % 10;
    Console.Write(inversNum);
}
if (num)