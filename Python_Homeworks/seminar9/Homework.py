'''Прикрутить телеграмм бота к задачам с предыдущего семинара:
Условие задачи: На столе лежит 221 конфета. Играют два игрока делая ход друг после друга. Первый ход определяется жеребьёвкой. 
За один ход можно забрать не более чем 28 конфет. 
Все конфеты оппонента достаются сделавшему последний ход.
Добавьте игру против бота ( где бот берет рандомное количество конфет от 0 до 28)
Подумайте как наделить бота ""интеллектом"" (есть алгоритм, позволяющий выяснить какое количесвто конфет необходимо брать, 
чтобы гарантированно победить, соответственно внедрить этот алгоритм боту )'''
import telebot
from telebot import types
import random

user_sweets = 0
flag = None
sweets = 60
max_sweets = 28
bot = telebot.TeleBot("6894937032:AAHvnkovDKX3syt5Tq8w9En8hSGQlGTLdpQ")


@bot.message_handler(commands=['start']) 
def start(message):
    global sweets, flag
    bot.send_message(message.chat.id, f"Приветствую вас в игре!") 
    flag = random.choice(["user", "bot"])
    bot.send_message(message.chat.id, f"Всего в игре {sweets} конфет")
    if flag == "user":
        bot.send_message(message.chat.id, f"Первым ходите вы")
    else:
        bot.send_message(message.chat.id, f"Первым ходит бот")
    controller(message)

def controller(message):
    global flag
    if sweets > 0:
        if flag == "user":
            bot.send_message(message.chat.id, f"Ваш ход, введите колличество конфет от 0 до {max_sweets}")
            bot.register_next_step_handler(message, user_input)
        else:
            bot_input(message)
    else:
        flag = "user" if flag == "bot" else "bot"
        bot.send_message(message.chat.id, f"победил {flag}")

def bot_input(message):
    global sweets,flag
    if sweets <= max_sweets:
        bot_turn = sweets
    elif sweets % max_sweets == 0:
        bot_turn = max_sweets - 1
    else:
        bot_turn = sweets % max_sweets - 1
    
    sweets -= bot_turn
    bot.send_message(message.chat.id, f"бот взял {bot_turn} конфет")
    bot.send_message(message.chat.id, f"осталось {sweets}")
    flag = "user" if flag == "bot" else "bot"
    controller(message)

def user_input(message):
    global sweets, flag
    user_turn = int(message.text)
    global sweets
    sweets -= user_turn
    bot.send_message(message.chat.id, f"осталось {sweets}")
    flag = "user" if flag == "bot" else "bot"
    controller(message)

bot.infinity_polling()