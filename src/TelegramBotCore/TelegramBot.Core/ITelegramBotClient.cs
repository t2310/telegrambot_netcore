using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TelegramBot.Core.Types;

namespace TelegramBot.Core
{
    public interface ITelegramBotClient
    {
        Task<Message> GetMe();

        Task<List<Update>> GetUpdates();

        Task<Message> SendMessage(BotMessage message);
    }
}
