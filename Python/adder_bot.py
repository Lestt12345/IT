import requests
from telegram.ext import Updater, CommandHandler, MessageHandler, Filters

# Массив токенов ботов
bot_tokens = [
    "YOUR_BOT_TOKEN_1",
    "YOUR_BOT_TOKEN_2",
    "YOUR_BOT_TOKEN_3",
    # Добавьте другие токены ботов
]

# Функция для отправки команды /start ботам
def start_bots(update, context):
    message = update.message.text
    if message.lower() == "adder начинай творить хаос":
        # Цикл по всем токенам ботов
        for bot_token in bot_tokens:
            url = f"https://api.telegram.org/bot{bot_token}/sendMessage"
            payload = {
                "chat_id": update.message.chat_id,
                "text": "Бот запускается! /start"
            }
            # Отправляем команду /start
            response = requests.get(f"https://api.telegram.org/bot{bot_token}/sendMessage", params={"chat_id": update.message.chat_id, "text": "/start"})
            if response.status_code == 200:
                update.message.reply_text(f"Команда /start отправлена бот с токеном {bot_token}.")
            else:
                update.message.reply_text(f"Ошибка при отправке команды /start через бот с токеном {bot_token}: {response.text}")

# Основная функция для обработки команд
def main():
    # Вставьте свой токен, полученный от BotFather
    updater = Updater("7548621067:AAFMrbjqOeqvDs4sRM0YIYoaR5R_jAVvWVo", use_context=True)
    
    # Получаем доступ к диспетчеру для обработки сообщений
    dispatcher = updater.dispatcher

    # Добавляем обработчик для сообщений
    dispatcher.add_handler(MessageHandler(Filters.text, start_bots))

    # Запускаем бота
    updater.start_polling()
    updater.idle()

if __name__ == '__main__':
    main()
