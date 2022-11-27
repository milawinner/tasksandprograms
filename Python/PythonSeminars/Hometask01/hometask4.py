# Напишите программу, которая по заданному номеру четверти, показывает 
# диапазон возможных координат точек в этой четверти (x и y).

x = int(input('Введите номер четверти (всего их четыре;): '))
if x == 1:
    print('Координаты точек первой четверти такие: x(0, +∞); y(0, +∞)')
elif x == 2:
    print('Координаты точек второй четверти такие: x(-∞, 0); y(0, +∞)')
elif x == 3: 
    print('Координаты точек третьей четверти такие: x(-∞, 0); y(-∞, 0)')
elif x == 4:
    print('Координаты точек четвёртой четверти такие: x(0, +∞); y(-∞, 0)')
else:
    print('Такой четверти не существует! Запускай снова.')