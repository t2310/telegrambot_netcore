using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBot.Core.Types
{
    public class MethodSendResult : MethodResultBase
    {
        public Message Result { get; set; }
    }
}
