#Напишите пограмму, которая на вход принимает 5 чисел и находит максимальное из них.
#Примеры: 
#1, 4, 8, 7, 6 ->8
#78, 55, 36, 90, 2 ->90

a = [int(input()) for i in range(5)]
# a = list(map(int, input().split()))
max = a[0]
for i in range(len(a)):
    if max < a[i]:
        max = a[i]
        
print(max)
    
