# 27. Задайте строку из набора чисел. Напишите программу,
# которая покажет большее и меньшее число. 
# В качестве символа-разделителя используйте пробел.

nums = input().split(" ")
#nums = list(map(int,nums))
#int(max(nums), min(nums))
max= int(nums[0])
min = int(nums[0])
for i in range(len(nums)):
    if int(nums[i]) > max:
        max = int(nums[i])
    if int(nums[i]) < min:
        min = int(nums[i])
print(f"min = {min}\n max = {max}")