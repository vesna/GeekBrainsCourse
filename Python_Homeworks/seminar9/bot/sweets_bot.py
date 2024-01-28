import telebot
from telebot import types

user_sweets = 0
sweets = 221
bot = telebot.TeleBot("5782756209:AAG-Rzx3ieL-JGwzHm5kGucQGT3TZ6nBhUw")


@bot.message_handler(commands=['start']) # вызов функции по команде в списке
def controller(message):
    global sweets
    bot.send_message(message.chat.id,
    f"Введите количество не больше 28") # отправка сообщения (кому отправляем, что отправляем(str))
    bot.register_next_step_handler(message, user_input)

def get_count(message):
    global sweets
    sweets = sweets - user_sweets
    bot.send_message(message.chat.id, f"осталось {sweets}")
    controller(message)

def user_input(message):
    global user_sweets
    user_sweets = int(message.text)
    get_count(message)

bot.infinity_polling()