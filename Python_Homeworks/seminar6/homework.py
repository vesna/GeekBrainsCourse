'''
Формат: Объясняет преподаватель
Задача: предложить улучшения кода для уже решённых задач:
- С помощью использования лямбд, filter, map, zip, enumerate, list comprehension
**44. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
Пример:
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21'''
# a = [int(input(f"Введите {i} координату точки a")) for i in "xy"]
# b = [int(input(f"Введите {i} координату точки a")) for i in "xy"]

# res = sum([(element[1] - element[0])**2 for element in zip(a,b)])**0.5
# print(res)

'''45. Найти сумму чисел списка стоящих на нечетной позиции'''
# import random
# a = [random.randint(1,10) for i in range(6)]
# res = [value for index,value in enumerate(a) if index%2==1]
# res = list(filter(lambda x: a[x] if x%2==1 else False,list(range(len(a)))))
# print(a)

'''46. Найти произведение пар чисел списка(парой считаем первый и последний, второй предпоследний и тд)'''
# import random
# a = [random.randint(1,10) for i in range(6)]
# res = [a[indx]*a[-indx-1] for indx in range(len(a)//2+len(a)%2)]
# print(a)
# print(res)

'''47.Сформировать список из N членов последовательности
Для N=5: 1,-3,9,-27,81 (каждый член больше предыдущего в три раза, знак чередуется)
'''
n = int(input())
res = [(-3)**i for i in range(n+1)]
print(res)