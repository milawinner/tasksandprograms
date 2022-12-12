# Создайте программу для игры в ""Крестики-нолики"".

field = [1, 2, 3, 4, 5, 6, 7, 8, 9]

print (f'{field[0]}') | {field[1]} | {field[2]}
print('---------')
print (f'{field[3]}') | {field[4]} | {field[5]}
print('---------')
print (f'{field[6]}') | {field[7]} | {field[8]}

turn = int(input('Ваш ход: '))

field[turn-1] = 'x'

print (f'{field[0]}') | {field[1]} | {field[2]}
print('---------')