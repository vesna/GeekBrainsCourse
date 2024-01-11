'''## 30 Вычислить число c заданной точностью d
##Пример:
##- при $d = 0.001, π = 3.141.$    $10^{-1} ≤ d ≤10^{-10}$'''
# import math
# d = input()
# length = d.split(".")[1]
# print(round(math.pi, length))
'''#31 Задайте натуральное число N. Напишите программу, которая составит список простых множителей числаN.
'''
# n = int(input())
# res_list = []
# cur_num = 2
# while n!=1:
#     if n%cur_num==0:
#         res_list.append(cur_num)
#         n = n//cur_num
#         cur_num = 2
#     else: 
#         cur_num +=1
# print(res_list)
'''#32 Задайте последовательность чисел. Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности.
'''
# a =[]
# res_list = []
# for i in a:
#     if a.count(i) == 1:
#         res_list.append(i)
# print(res_list)
'''#33 Задана натуральная степень k. Сформировать случайным образом список коэффициентов (значения от 0 до 100) многочлена и записать в файл многочлен степени k.
#Пример:
#- k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0
'''
# import random
# k = int(input())
# result = ""
# for i in range(k,-1,-1):
#     if koef==0:
#         continue
#     if i == 1:
#         koef = random.randint(0, 100)
#         if koef>1:
#             result += f"{koef}*x"
#         if koef==1:
#             result += f"x"
#     if i>1:
#         if koef>1:
#             result += f"{koef}*x**{i}"
#         if koef==1:
#             result += f"x**{i}"
#     if i==0:
#         if koef>1:
#             result += f"{koef}"
#         if koef==1:
#             result += f"1"
# print(result[:-1]+" = 0")

# import random
# k = int(input('Введите натуральную степень k: '))
# coef_list = [random.randint(0,100) for i in range(k+1)]
# print(coef_list)
# path = 'polynomial.txt'
# with open(path, 'w') as data:
#     for i in range(k, -1, -1):
#         if coef_list[i] == 0:
#             continue
#         data.write(str(coef_list[i]) + ('*x' if i!=0 else ''))
#         data.write(('**'+str(i)) if i > 1 else '')
#         data.write('+' if i!=0 else '')
#     data.write('=0')

'''#35Даны два файла, в каждом из которых находится запись многочлена. Задача - сформировать файл, содержащий сумму многочленов.'''
pol1 = "2*x**10+3*x**9+2*x**8+3*x**7+1*x**6+2*x**5+3*x**4+3"
pol2 = "6*x**13+3*x**10+2*x**7+1*x**6+2*x**2+3*x**1+10"
print(pol1)
print(pol2)
pol1 = pol1.split("+")
pol2 = pol2.split("+")

print(pol1)
print(pol2)

for indx,value in enumerate(pol1):
    pol1[indx] = list(map(int,(value.split("*x**"))))

for indx,value in enumerate(pol2):
    pol2[indx] = list(map(int,(value.split("*x**"))))
print(pol1)
print(pol2)

result_pol = pol1 + pol2
print(result_pol)

polyn_dict = {}

for value in result_pol:
    if len(value)>1:
        if value[1] in polyn_dict.keys():
            polyn_dict[value[1]]+=value[0]
        else:
            polyn_dict[value[1]] = value[0]
    else:
        if 0 in polyn_dict.keys():
            polyn_dict[0]+=value[0]
        else:
            polyn_dict[0] = value[0]
print(polyn_dict)
result_pol = dict(sorted(polyn_dict.items(),reverse=True))
print(result_pol)
finish_line = ""
for stepen,koeff in result_pol.items():
    if stepen>1:
        finish_line+=f"{koeff}*x**{stepen}+"
    if stepen == 0:
        finish_line += f"{koeff}"

print(finish_line)