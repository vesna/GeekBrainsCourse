# Напишите программу,которая принимает на вход число N и выдает последователность из N членов.
# Каждый член последовательности больше предыдущего в 3 раза, знаки у элементов чередуются.
#Пример:
#Для N =5: 1, -3, 9, -27, 81

n = int(input('Введите число N '))
x = 1
for i in range(n):
    print(x)
    x = x*3*-1