# Напишите программу, которая принимает на вход координаты двух точек 
# и находит расстояние между ними в 2D пространстве.

print('Введите координаты первой точки: ')
x1 = int(input('x1: '))
y1 = int(input('y1: '))
print('Введите координаты второй точки: ')
x2 = int(input('x2: '))
y2 = int(input('y2: '))

ABlenght = (((x2-x1)**2+(y2-y1)**2))**(0.5)
print(f'Расстояние между точками равно {round(ABlenght, 3)}.')