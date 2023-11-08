#20. Задайте список. Напишите программу, которая определит, 
# присутствует ли в заданном списке строк некое число.

a = ["sr","ere","12","wewe"]
n = int(input())
for i in a:
    if i.isdigit() and int(i) == n:
        print(a.index(i))
n = int(input())
if n in a:
    print(a.index(n))
else:
    print(-1)