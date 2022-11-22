# Напишите программу для проверки истинности утверждения 
# ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

print('Проверям истинность выражения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z при всех значениях:')
for i in range (2):
    X = True
    if i == 1:
        X = False
    for j in range (2):
        Y = True
        if j == 1:
            Y = False
        for d in range (2):
            Z = True
            if d == 1:
                Z = False
            print(f'X = {X}, Y = {Y}, Z = {Z}, то истинность выражения = {not(X or Y or Z) == (not X and not Y and not Z)}')
