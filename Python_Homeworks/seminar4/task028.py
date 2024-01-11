# 28. Найдите корни квадратного уравнения Ax² + Bx + C = 0 двумя способами:

# 1) с помощью математических формул нахождения корней квадратного уравнения

# 2) с помощью дополнительных библиотек Python
import math
a = int(input("Введите а: "))
b = int(input("Введите b: "))
c = int(input("Введите c: "))

dis = math.pow(b, 2)-4*a*c
if a != 0:
    if dis >0:
        x1 = (-b + math.sqrt(dis))/(2*a)
        x2 = (-b - math.sqrt(dis))/(2*a)
        print(f"x1 = {x1} x2 = {x2}")
    elif dis ==0:
        x = -b/(2*a)
        print(f"x = {x}")
    else:
        print("Корней нет")
else:
    x = -c/b
    print(x)