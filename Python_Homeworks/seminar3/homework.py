#22.Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, 
#стоящих на нечётной позиции.
#Пример:
#- [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12

# N = int(input('Введите размер списка: '))
# list = []
# for i in range(N):
#     list.append(input())
# count = 1
# result = 0
# while(N > count):
#     result += int(list[count])
#     count += 2
# print(result)
    
#23. Напишите программу, которая найдёт произведение пар чисел списка. 
# Парой считаем первый и последний элемент, второй и предпоследний и т.д.
#Пример:
#- [2, 3, 4, 5, 6] => [12, 15, 16];
#- [2, 3, 5, 6] => [12, 15]

# N = int(input('Введите размер списка: ')) 
# list = []
# for i in range(N):
#     list.append(input())
# count = 0
# while(N/2 >= count):
#     print(int(list[count])*int(list[N - 1 -count]))
#     count += 1

#24. Задайте список из вещественных чисел. Напишите программу, 
# которая найдёт разницу между максимальным и минимальным значением дробной части элементов.
# Пример:
# - [1.1, 1.2, 3.1, 5, 10.01] => 0.19
# N = int(input('Введите размер списка: ')) 
# list = []
# for i in range(N):
#     list.append(float(input()))
# min = list[0] % 1
# max = list[0] % 1
# for i in range(1, N):
#     result = list[i] % 1
#     if result > max:
#         max = result
#     if result < min:
#         min = result
# print(max - min)

# 25. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
# Пример:
# - 45 -> 101101
# - 3 -> 11
# - 2 -> 10

# N = int(input('Введите десятичное число: ')) 
# result = []
# x = N//2
# while N > 0:
#     y = N - x * 2
#     N = x
#     x = x//2
#     result.append(y)
# strresult = ''
# for i in range(len(result), 0, -1):
#     strresult += str(result[i-1])
# print(strresult)

# 26.Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.
# Пример:
# - для k = 8 список будет выглядеть так: 
# [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21] 
# [Негафибоначчи](https://ru.wikipedia.org/wiki/%D0%9D%D0%B5%D0%B3%D0%B0%D1%84%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D1%87%D0%B8#:~:text=%D0%92%20%D0%BC%D0%B0%D1%82%D0%B5%D0%BC%D0%B0%D1%82%D0%B8%D0%BA%D0%B5%2C%20%D1%87%D0%B8%D1%81%D0%BB%D0%B0%20%D0%BD%D0%B5%D0%B3%D0%B0%D1%84%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D1%87%D0%B8%20%E2%80%94%20%D0%BE%D1%82%D1%80%D0%B8%D1%86%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%20%D0%B8%D0%BD%D0%B4%D0%B5%D0%BA%D1%81%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%BD%D1%8B%D0%B5%20%D1%8D%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82%D1%8B%20%D0%BF%D0%BE%D1%81%D0%BB%D0%B5%D0%B4%D0%BE%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D1%8C%D0%BD%D0%BE%D1%81%D1%82%D0%B8%20%D1%87%D0%B8%D1%81%D0%B5%D0%BB%20%D0%A4%D0%B8%D0%B1%D0%BE%D0%BD%D0%B0%D1%87%D1%87%D0%B8.)

N = int(input('Введите десятичное число: ')) 
list = []
fib1 = fib2 = 1
list.append(fib1)
list.append(fib2)

# print(fib1, fib2, end=' ')
 
for i in range(2, N):
    fib1, fib2 = fib2, fib1 + fib2
    list.append(fib2)

result = []
for i in range(len(list), 0, -1):
    result.append((-1)**(i + 1) * list[i-1])
    
result.append(0)
for i in range(len(list)):
    result.append(list[i])
for i in range(len(result)):
    print(result[i])