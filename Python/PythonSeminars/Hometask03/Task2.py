# Напишите программу, которая найдёт произведение пар чисел списка. 
# Парой считаем первый и последний элемент, второй и предпоследний и т.д.
# Пример:
# [2, 3, 4, 5, 6] => [12, 15, 16]
# [2, 3, 5, 6] => [12, 15]

# my_list = [2, 3, 4, 5, 6]
my_list = [2, 3, 5, 6]

product_pairs = round(len(my_list)/2)
if product_pairs < len(my_list) / 2:
    product_pairs += 1
new_list = []
i = 0
while i < product_pairs:
    new_list.append(my_list[i] * my_list[len(my_list) - i - 1])
    i += 1
print(new_list)
