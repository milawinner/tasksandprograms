# Пройтись по своим предыдущим ДЗ и где возможно использовать ускореную обработку данных.
# Реализуйте алгоритм перемешивания списка. Встроенный алгоритм SHUFFLE не использовать! Реализовать свой метод
# Использовала в части List comprehension

# import random

# n = int(input('Введите количество элементов списка (лучше небольшое для наглядности): '))
# my_list = []
# for i in range(1, n+1):
#     my_list.append(i)
# print(my_list)

n = int(input('Введите количество элементов списка (лучше небольшое для наглядности): '))
my_list = [i for i in range(1, n+1)]
print(my_list)

# my_list2 = my_list
# list_len = len(my_list2)
# for i in range(list_len):
#     temp = my_list2[random(list_len - 1)]
#     my_list2[i] = temp
#     temp = my_list2[i]
# print(my_list2)



