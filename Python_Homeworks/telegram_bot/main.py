from telegram import Update
from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes
from bot_comands import *


app = ApplicationBuilder().token("6894937032:AAHvnkovDKX3syt5Tq8w9En8hSGQlGTLdpQ").build()
print("server start")
app.add_handler(CommandHandler("hi", hi_command))
app.add_handler(CommandHandler("time", time_command))
app.add_handler(CommandHandler("help", help_command))
app.add_handler(CommandHandler("sum", sum_command))

app.run_polling()