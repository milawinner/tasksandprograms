# A. Задана натуральная степень k. Сформировать случайным образом список коэффициентов 
# (значения от 0 до 100) многочлена и записать в файл многочлен степени k.
# Пример: 
# если k = 2, то многочлены могут быть => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0

import random

num = int(input('Введите степень для многочлена: '))
x = ''
for k in range(num, 0, -1):
    x += f'{random.randint(0,100)}*x**{k} + '
    # if k == 1:
    #     x += f'{random.randint(0,100)}*x'
    # Здесть попыталась убрать плюс на конце многочлена, но не получается. 
    # По такой формуле + уходит, но появляется два ненужных слагаемый.
print(x, '= 0')

#Здесь очищаю список от плюсов, остаются 4 элемента для суммы многочлена.
for_sum1 = x.split()
print(for_sum1)
del(for_sum1[7])
del(for_sum1[5])
del(for_sum1[3])
del(for_sum1[1])
print(for_sum1)


# for_sum1_dictionary = dict.fromkeys(for_sum1, "*x**")
# print(for_sum1_dictionary)

