'''
Далее заадчи на выбор:
39(1). Создайте программу для игры с конфетами человек против человека. Реализовать игру игрока против игрока в терминале. 
Игроки ходят друг за другом, вписывая желаемое количество конфет. Первый ход определяется жеребьёвкой. 
В конце вывести игрока, который победил
Условие задачи: На столе лежит 221 конфета. Играют два игрока делая ход друг после друга. Первый ход определяется жеребьёвкой. За один ход можно забрать не более чем 28 конфет. Все конфеты оппонента достаются сделавшему последний ход. 
В качестве дополнительного усложнения можно:
        a) Добавьте игру против бота ( где бот берет рандомное количество конфет от 0 до 28)

        b) Подумайте как наделить бота ""интеллектом"" (есть алгоритм, позволяющий выяснить какое количесвто конфет необходимо брать, чтобы гарантированно победить, соответственно внедрить этот алгоритм боту )
'''
# import random
# def pvp():
#     name1 = input("Введите имя первого игрока - ")
#     name2 = input("Введите имя второго игрока - ")
#     sweets = int(input("Введите желаемое количество конфет - "))
#     max_sweet = int(input("Введите максимум конфет на ход"))
    
#     first_turn = random.choice([name1,name2])
#     flag = name1 if first_turn == name1 else name2
#     while sweets>0:
#         print(f"Выш ход {flag}")
#         turn = int(input("введите желаемое количество конфет для взятия - "))
#         while not 0 < turn <= max_sweet:
#             print("введите конфеты в диапозоне от 0 до ", max_sweet)
#             turn = int(input("введите желаемое количество конфет для взятия - "))
            
#         sweets -= turn
#         if sweets >0:
#             print(f"конфет осталось - {sweets}")
#         else: 
#             print(f"конфет осталось - 0")
            
#         flag = name2 if flag == name1 else name1
#     winner = name2 if flag ==name1 else name1
#     print(f"Поздравляем, победил игрок {winner}")

# def pve_st():
#     name1 = input("Введите имя первого игрока - ")
#     name2 = "bot"
#     sweets = int(input("Введите желаемое количество конфет - "))
#     max_sweet = int(input("Введите максимум конфет на ход"))
    
#     first_turn = random.choice([name1,name2])
#     flag = name1 if first_turn == name1 else name2
#     while sweets>0:
#         print(f"Выш ход {flag}")
#         if flag == name1:
#             turn = int(input("введите желаемое количество конфет для взятия - "))
#             while not 0 < turn <= max_sweet:
#                 print("введите конфеты в диапозоне от 0 до ", max_sweet)
#                 turn = int(input("введите желаемое количество конфет для взятия - "))
                
#             sweets -= turn
#             if sweets >0:
#                 print(f"конфет осталось - {sweets}")
#             else: 
#                 print(f"конфет осталось - 0")
            
#             flag = name2 if flag == name1 else name1
#         else:
#             turn = random.randint(1,max_sweet)
#             print(f"бот взял {turn} конфет")
#             sweets -= turn
#             if sweets >0:
#                 print(f"конфет осталось - {sweets}")
#             else: 
#                 print(f"конфет осталось - 0")
            
#             flag = name2 if flag == name1 else name1
    
#     winner = name2 if flag ==name1 else name1
#     print(f"Поздравляем, победил игрок {winner}")

# def pve_smart():
#     name1 = input("Введите имя первого игрока - ")
#     name2 = "bot"
#     sweets = int(input("Введите желаемое количество конфет - "))
#     max_sweet = int(input("Введите максимум конфет на ход"))
    
#     first_turn = random.choice([name1,name2])
#     flag = name1 if first_turn == name1 else name2
#     while sweets>0:
#         print(f"Выш ход {flag}")
#         if flag == name1:
#             turn = int(input("введите желаемое количество конфет для взятия - "))
#             while not 0 < turn <= max_sweet:
#                 print("введите конфеты в диапозоне от 0 до ", max_sweet)
#                 turn = int(input("введите желаемое количество конфет для взятия - "))
                
#             sweets -= turn
#             if sweets >0:
#                 print(f"конфет осталось - {sweets}")
#             else: 
#                 print(f"конфет осталось - 0")
            
#             flag = name2 if flag == name1 else name1
#         else:
#             if sweets <= max_sweet:
#                 turn = sweets
#             elif sweets%max_sweet==0:
#                 turn = max_sweet-1
#             else:
#                 turn = sweets%max_sweet-1
#             print(f"бот взял {turn} конфет")
#             sweets -= turn
#             if sweets >0:
#                 print(f"конфет осталось - {sweets}")
#             else: 
#                 print(f"конфет осталось - 0")
            
#             flag = name2 if flag == name1 else name1
    
#     winner = name2 if flag ==name1 else name1
#     print(f"Поздравляем, победил игрок {winner}")
'''
39(2). Создайте программу для игры в ""Крестики-нолики"". Игра реализуется в терминале, игроки ходят поочередно, 
необходимо вывести карту(как удобнее, можно например в виде списка, внутри которого будут 3 списка по 3 элемента, 
каждый из которого обозначает соответсвующие клетки от 1 до 9), сделать проверку не занята ли клетка, на которую 
мы хотим поставить крестик или нолик, и проверку на победу( стоят ли крестики или нолик в ряд по диагонали, вертикали, 
горизонтали)
'''
# import random
# maps = [1, 2, 3, 4, 5, 6, 7, 8, 9]
# victories = [[0, 1, 2], [3, 4, 5], [6, 7, 8], [0, 3, 6], [1, 4, 7], [2, 5, 8], [0, 4, 8], [2, 4, 6]]

# def print_maps():
#     print(maps[0], end=" ")
#     print(maps[1], end=" ")
#     print(maps[2])
#     print(maps[3], end=" ")
#     print(maps[4], end=" ")
#     print(maps[5]),
#     print(maps[6], end=" ")
#     print(maps[7], end=" ")
#     print(maps[8])

# def check_victories():
#     for i in victories:
#         if maps[i[0]] == maps[i[1]] == maps[i[2]]:
#             return True
#     return False
        
# print_maps()

# name1 = input("Введите имя первого игрока - ")
# name2 = input("Введите имя второго игрока - ")
# first_turn = random.choice([name1,name2])
# cur_turn = first_turn
# count = 0
# while True:
#     print(f"сейчас ходит {cur_turn}")
#     if cur_turn==first_turn:
#         symbol = "X"
#         step = int(input("введите клетку от 1 до 9, куда хотите походить"))
#         if maps[step-1] in ["X","0"]:
#             print("клетка занята")
#             continue
#         maps[step-1] = symbol
#     else:
#         symbol = "0"
#         step = int(input("введите клетку от 1 до 9, куда хотите походить"))
#         if maps[step-1] in ["X","0"]:
#             print("клетка занята")
#             continue
#         maps[step-1] = symbol
#     print_maps()
#     if check_victories():
#         print(f"Поздравляем, победил игрок {cur_turn}")
#         break
#     count+=1
#     cur_turn = name2 if cur_turn ==name1 else name1
#     if count==9:
#         print("Ничья")
#         break
'''
Обязательная:
40. Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных.
Модуль сжатия:
Для чисел:
Входные данные:
111112222334445
Выходные данные:
5142233415
Также должно работать и для букв:
Входные данные:
AAAAAAFDDCCCCCCCAEEEEEEEEEEEEEEEEE
Выходные данные:
6A1F2D7C1A17E
(5 - количество единиц, далее сама единица, 4 - количество двоек, далее сама двойка и т.д)
Модуль восстановления работет в обратную сторону - из строки выходных данных, получить строку входных данных.

'''
def encode(text):
    result=""
    count = 0
    prev_char = text[0]
    for char in text:
        if char != prev_char:
            result += f"{count}{prev_char}"
            prev_char = char
            count = 1
        else:
            count += 1
    else:
        result += f"{count}{prev_char}"
    return result

def decode(text):
    result = ""
    digit = True
    count = 0
    for char in text:
        if digit:
            count=int(char)
            digit = False
        else:
            result+=count*char
            digit = True
    return result
    
text = '111112222334445'
print(f'Исходный текст: {text}')
encode_text = encode(text)
decode_text = decode(encode_text)
print(f'Результат сжатия данных {encode_text}')
print(f'Результат сжатия данных {decode_text}')