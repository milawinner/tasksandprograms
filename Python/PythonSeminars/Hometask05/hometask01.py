# Создайте программу для игры с конфетами. # Условие задачи: На столе лежит 150 конфет.
# Играют два игрока (человек и бот) делая ход друг после друга. Первый ход определяется жеребьёвкой.
# За один ход можно забрать не более чем 28 конфет.
# Все конфеты оппонента достаются сделавшему последний ход.
# Сколько конфет нужно взять первому игроку, чтобы забрать все конфеты у своего конкурента?
# b) Подумайте как наделить бота ""интеллектом""

import random
from random import randint

print('Игра в конфеты. На столе лежит 150 конфет. Выигрывает тот, кто берёт последним.')

player = 'Первым ходите Вы.'
bot = 'Первый ходит робот.'
first_or_second = randint(0,2)
if first_or_second:
    print(player)
else:
    print(bot)

total = 150
while total > 28:
    if first_or_second:
        player = int(input('Возьмите любое количество конфет, но не больше 28. Сколько берёте? '))
        if player > 28:
            print('Ай-ай-ай. Не больше 28 конфет, сладкоежка! Давай ещё раз. Сколько возьмёшь? ')
            player = int(input())
        total -= player
        first_or_second = False
        print(f'Осталось {total} конфет из 150.')
    else: 
        bot = random.randint(1, 28)
        print(f'Робот берёт {bot}.')
        total -= bot
        first_or_second = True
        print(f'Осталось {total} конфет из 150.')

if first_or_second:
    print(f"Выиграли вы!")
else:
    print(f"Выиграл робот! Восстание машин близко!")