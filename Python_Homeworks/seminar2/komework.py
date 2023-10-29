# 14.Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
# Пример:
# - 6782 -> 23
# - 0,56 -> 11

# a = input('Введите вещественное число: ')
# result = 0
# for i in range(len(a)):
#     result += int(a[i])
# print(result)

# 15.Напишите программу, которая принимает на вход число N 
# и выдает набор произведений чисел от 1 до N.
# Пример:
# - пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)

# a = int(input())
# for i in range(a):
#     f = 1
#     while i + 1 > 1:
#         f *= i + 1
#         i -= 1
#     print(f)

# 16.Задайте список из n чисел последовательности (1 + 1/n)^n и выведите на экран их сумму.
# Пример:
# - Для n=4 {1: 2, 2: 2.25, 3: 2.37, 4: 2.44}
#         Сумма 9.06

# n = int(input())
# result = 0
# for i in range(n):
#     list = (1 + 1/(i + 1))**(i + 1)
#     result += list
# print(result)

# 17.Задайте список из N элементов, заполненных числами из промежутка [-N, N]. 
# Найдите произведение элементов на указанных позициях. 
# Позиции хранятся в файле file.txt в одной строке одно число.

n = abs(int(input()))
list = []
for i in range(-n, n+1):
    list.append(i)
print(list)
with open('seminar2/file.txt', 'r') as f:
    nums = f.read().splitlines()
print(nums)
result = 1
for i in nums:
    result *= list[int(i) - 1]
print(result)

# 18.Реализуйте алгоритм перемешивания списка.
# from random import shuffle
# nums = list(range(10))
# shuffle(nums)
# print(nums)
