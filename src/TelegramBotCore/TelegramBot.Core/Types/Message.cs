using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBot.Core.Types
{
    public class Message
    {
        [JsonProperty("message_id")]
        public int Id { get; set; }

        public int Date { get; set; }

        public Chat Chat { get; set; }

        public string Text { get; set; }

        public List<MessageEntity> Entities { get; set; } = new List<MessageEntity>();
    }
}
