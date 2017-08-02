using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBot.Core.Types
{
    public class BotDocument
    {
        [JsonProperty("chat_id")]
        public int ChatId { get; set; }

        public string Document { get; set; }
    }
}
