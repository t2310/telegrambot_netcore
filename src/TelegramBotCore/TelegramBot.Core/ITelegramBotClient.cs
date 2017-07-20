using System;
using System.Collections.Generic;
using System.Text;
using TelegramBot.Core.Types;

namespace TelegramBot.Core
{
    public interface ITelegramBotClient
    {
        Message GetMe();

        List<Update> GetUpdates();

        Message SendMessage(BotMessage message);
    }
}
