# Напишите программуб которая будет на вход приниматьчисло N и вводить числа от -N до N
# Примеры:-5 -> -5 -4 -3 -2 -1 0 1 2 3 4 5

a = abs(int(input()))

for i in range(-a, a+1):
    print(i, end = " ")
    