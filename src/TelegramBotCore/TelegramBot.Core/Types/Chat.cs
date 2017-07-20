using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBot.Core.Types
{
    public class Chat
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Title { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        public bool AllMembersAreAdministrators { get; set; }

        public string Description { get; set; }

        public string InviteLink { get; set; }
    }
}
