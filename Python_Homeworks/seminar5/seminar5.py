#lambda, filter, map, zip, enumerate, list comprehension

# a = []
# for i in range(1,9):
# a.append(i)
# print(a)
#list comprehension
# a = [i*i for i in range(1,9)]
# print(a)
#enumerate
# a = [1, 4, 9, 16, 25, 36, 49, 64]
# for indx,value in enumerate(a):
# print(indx,value)
#zip
# num=[1,2,3,4,5,6,7]
# months = ["июнь", "июль","июль2","июль3","июль4","июль5"]
#
# a = list(zip(num,months))
# print(a)
#lambda
# def summ(a,b):

# return a+b
# print(summ(3,5))

# summ = lambda a,b: a+b if a>5 else 0
# print(summ(2,5))

#map
# a = [i for i in range(12)]
# print(a)
# a = list(map(lambda x:x+10 if x >6 else x + 0,a))
# print(a)
#filter
# a = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11]
# def chek_num(x):
# if x%2==0:
# return True
# a_chet = list(filter(lambda x:True if x%2 == 0 else False,a))
# print(a_chet)
'''
#35)Напишите программу на Python для поиска пересечения двух заданных массивов с помощью Lambda.
'''
#a = [1, 2, 3, 5, 7, 8, 9, 10]
#b = [1, 2, 4, 8, 9]
#result = list(filter(lambda x: x in a, b))
#print(result)
'''
#36)Сделать с помощью filter, lambda
#Напишите программу, удаляющую из текста все слова, содержащие "абв".
#Вывести все пробелы и их индексы из предыдущей строки.
'''
#text = "ааабваа! аааа, аабв вввв. Абв ггг"
# text_list = text.split()
# result = list(filter(lambda x: not "абв" in x.lower() ,text_list))
# print(result)
'''
#37)Имеется упорядоченный список:
#A = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
#Перебрать все элементы этого списка с помощью функций enumerate и элементы, стоящие на главной диагонали (имеющие равные индексы), превратить в нули.
'''
# a =[[1,2,3],
#    [4,5,6],
#    [7,8,9]]
# for index, val in enumerate(a):
#     print(index, val)
    

# for indx,val in enumerate(a):
# for indx2,val2 in enumerate(val):
# if indx == indx2:
# val[indx2] = 0
# print(a)

'''#38)Имеется список id сотрудников из 10 элементов, каждый id - случайное число от 1 до 100
#Имеется список имен сотрудников из 10 элементов
#Сопоставьте каждому имени сотрудника его id, и выведите получившийся список.
#Выведете имена сотрудников, получившие нечетное id. Решить с помощью zip,filter,lambda
'''
# id = [random.randint(1,100) for i in range(10)]
# name = ["cds",'dsds','sdsd1','sdsd2','sdsd3','sdsd4','sdsd5','sdsd6','sdsd7','sdsd8']
# print(id)
# res_list = list(zip(id,name))
# print(res_list)
# res_list_2 = list(filter(lambda x: x[0]%2==1,res_list))
# print(res_list_2)