using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBot.Core.Types
{
    public class Update
    {
        [JsonProperty("update_id")]
        public int Id { get; set; }

        public Message Message { get; set; }
    }
}
