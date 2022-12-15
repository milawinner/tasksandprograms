# Пройтись по своим предыдущим ДЗ и где возможно использовать ускореную обработку данных.
# Напишите программу, удаляющую из текста все слова, содержащие ""абв"".

string = 'Знания без тренировки абвсолютно абвстракты забываются.'
print(string)
string = string.split()

string = list(filter(lambda a: 'абв' not in a, string))

string = ' '.join(string)
print(string)