using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBot.Core.Types
{
    public class BotMessage
    {
        [JsonProperty("chat_id")]
        public int ChatId { get; set; }

        public string Text { get; set; }

        [JsonProperty("disable_notification")]
        public bool DisableNotification { get; set; }

        [JsonProperty("reply_to_message_id")]
        public int ReplyToMessageId { get; set; }
    }
}
