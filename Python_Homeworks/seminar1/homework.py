#6. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
# и проверяет, является ли этот день выходным.
#Пример:
#- 6 -> да
#- 7 -> да
#- 1 -> нет

# a = int(input())
# if a in range(1, 5):
#     print('yes')
# elif a in range(6, 7):
#     print('no')
    
#7. Напишите программу для. 
# проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

# print('¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z')
# for x in range(2):
#     for y in range(2):
#         for z in range(2):
#             if not(x or y or z) == (not(x) and not(y) and not(z)):
#                 print(f'{x} {y} {z} yes')
#             else:
#                  print(f'{x} {y} {z} no')

#8. Напишите программу, которая принимает на вход координаты точки (X и Y), 
# причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
# в которой находится эта точка (или на какой оси она находится).
# Пример:
# - x=34; y=-30 -> 4
# - x=2; y=4-> 1
# - x=-34; y=-30 -> 3

# print('X = ') 
# x = int(input())
# print('Y = ')
# y = int(input())
# if (x > 0 and y > 0): print('1')
# elif x > 0 and y < 0: print('2')
# elif x < 0 and y < 0: print('3') 
# elif x < 0 and y > 0: print('4')               

#9. Напишите программу, которая по заданному номеру четверти, 
#показывает диапазон возможных координат точек в этой четверти (x и y).

# a = int(input())
# if a == 1: print(f'x > 0 and y > 0')
# elif a == 2: print(f'x > 0 and y < 0')
# elif a == 3: print(f'x < 0 and y < 0')
# elif a == 4: print(f'x < 0 and y > 0')

#10. Напишите программу, которая принимает на вход координаты двух точек 
# и находит расстояние между ними в 2D пространстве.
#Пример:
#- A (3,6); B (2,1) -> 5,09
#- A (7,-5); B (1,-1) -> 7,21

# print('Ax = ') 
# ax = int(input())
# print('Ay = ')
# ay = int(input())
# print('Bx = ') 
# bx = int(input())
# print('By = ')
# by = int(input())

# print(f'AB = {((bx-ax)**2 + (by-ay)**2)**(0.5)}')