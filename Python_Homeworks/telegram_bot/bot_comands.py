from telegram import Update
from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes
import datetime
from spy import *

async def hi_command(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    log(update, context)
    await update.message.reply_text(f'Hi {update.effective_user.first_name}!')

async def time_command(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    log(update, context)
    await update.message.reply_text(f'{datetime.datetime.now().time()}')

async def help_command(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    log(update, context)
    await update.message.reply_text(f'/hi\n/time\n/help')

async def sum_command(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    log(update, context)
    msg = update.message.text
    print(msg)
    item = msg.split()
    x = int(item[1])
    y = int(item[2])
    await update.message.reply_text(f'{x} + {y} = {x+y}')
