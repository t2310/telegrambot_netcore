using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBot.Core.Types
{
    public class GetMeResult : MethodResultBase
    {
        public User User { get; set; }
    }
}
