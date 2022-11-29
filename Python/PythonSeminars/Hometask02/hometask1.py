# Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
# Пример:
# 6782 -> 23
# 0,56 -> 11

num = int(input('Введите число: '))
sumnum = 0
while (num > 0): 
    sumnum = sumnum + num % 10
    num //= 10
print(f'{sumnum} - это сумма цифр во введённом числе.')

# for i in num:
#     sumnum += int(i)
# print(sumnum)